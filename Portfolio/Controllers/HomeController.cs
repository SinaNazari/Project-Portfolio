using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contact = new ContactModel()
            {
                Email = "Sina@gmail.com",
                PhoneNumber = "091234354",
                WebSite = "www.github.com/SinaNazari"
            };
            return View(contact);
        }
    }

}

