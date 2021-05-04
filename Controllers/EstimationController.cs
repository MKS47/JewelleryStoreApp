using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JewelleryStoreApp.Models;
using System.Xml.Serialization;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.Text;

namespace JewelleryStoreApp.Controllers
{
    public class EstimationController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        public EstimationController(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            var userModel = JsonConvert.DeserializeObject<User>(Convert.ToString(TempData["ValidUser"]));
            var priceDetail = new PriceDetail
            {
                UserType = userModel.Type,
                Discount = Convert.ToDouble(userModel.Discount)
            };
            return View("Estimation", priceDetail);
        }

        [HttpPost]
        public IActionResult Calculate(PriceDetail priceDetail)
        {
            var discountValue = (priceDetail.PricePerGram * priceDetail.Discount * .01);
            priceDetail.TotalPrice = (priceDetail.PricePerGram * priceDetail.Weight) - discountValue;
            return View("Estimation", priceDetail);
        }

        [HttpPost]
        public IActionResult PrintFile(PriceDetail priceDetail)
        {
            var filepath = string.Concat(_webHost.ContentRootPath, "/priceEstimation.txt");
            var content = getEstmationReportString(priceDetail);
            return File(Encoding.UTF8.GetBytes(content), "text/plain", "PriceEstimation.txt");
        }


        [HttpPost]
        public IActionResult PrintPaper(PriceDetail priceDetail)
        {
            throw new NotImplementedException();
        }

        private static string getEstmationReportString(PriceDetail priceDetail)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Price Estimation");
            sb.AppendLine($" Gold Price (per gram) : {priceDetail.PricePerGram}");
            sb.AppendLine($"Weight (grams) : {priceDetail.Weight}");
            sb.AppendLine($"Discount % : {priceDetail.Discount}");
            sb.AppendLine($"Total Price : {priceDetail.TotalPrice}");
            return sb.ToString();
        }

    }
}