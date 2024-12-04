using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1_HW_27_11_2024_ADD1.Models;

namespace WebApplication1_HW_27_11_2024_ADD1.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }
    }
}
