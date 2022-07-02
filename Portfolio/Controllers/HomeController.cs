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
        private readonly List<PortfolioModel> _portfolios = new List<PortfolioModel>()
        {
            new PortfolioModel
            {
                Id =1,Title="First_Photo",Image="01.jpg",Description="This is first Photo"
            },
            new PortfolioModel
            {
                Id =2,Title="Tow_Photo",Image="02.jpg",Description="This is Tow Photo"
            },
            new PortfolioModel
            {
                Id =3,Title="Three_Photo",Image="03.jpg",Description="This is There Photo"
            },
            new PortfolioModel
            {
                Id =4,Title="Fore_Photo",Image="04.jpg",Description="This is Fore Photo"
            },
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "Welcome to My WebSite";
            ViewData["headingText"] = "Hi My Name is Sina Nazari I A Programmer";
            return View(_portfolios);
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

