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

namespace JewelleryStoreApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private User validUser;
        public LoginController(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (IsValidUser(user))
            {
                TempData["ValidUser"] =  JsonConvert.SerializeObject(validUser);
                return RedirectToAction("Index", "Estimation");
            }
            return View("Error");
        }

        private List<User> DeserializeXml(string filename)
        {
            var xmlReader = new XmlSerializer(typeof(List<User>), new XmlRootAttribute("Users"));
            var filePath = string.Concat(_webHost.ContentRootPath, filename);
            using (var xr = new StreamReader(filePath))
            {
                return (List<User>)xmlReader.Deserialize(xr);
            }
        }

        private bool IsValidUser(User request)
        {
            var users = DeserializeXml("/UserList.xml");
            foreach (User user in users)
            {
                if (request.UserName == user.UserName && request.Password == user.Password)
                {
                    validUser = user;
                    return true;
                }
            }
            return false;
        }
    }
}