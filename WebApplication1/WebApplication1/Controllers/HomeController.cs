using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private static string f = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "file.txt");//путь до файла

        public ActionResult Index(string T)//action
        {
            if (!string.IsNullOrWhiteSpace(T))
            {
                System.IO.File.AppendAllText(f, $"{T}{Environment.NewLine}");
            }

            return View();
        }
  

        public ActionResult About()
        {
            ViewBag.Lines = System.IO.File.ReadAllLines(f);

            return View();
        }

    }
}