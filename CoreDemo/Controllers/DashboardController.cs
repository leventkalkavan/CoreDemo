using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.vl = c.Blogs.Count().ToString();
            ViewBag.vl3 = c.Categories.Count();
            ViewBag.vl2 = c.Blogs.Where(x=>x.WriterID==1).Count().ToString();
            return View();
        }
    }
}
