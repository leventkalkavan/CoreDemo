using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMEssageRepository());
        public IActionResult Index()
        {
            return View();
        }
    }
}
