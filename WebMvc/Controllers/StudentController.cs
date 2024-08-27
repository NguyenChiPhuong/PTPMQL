using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using FirstWeb.Models;

namespace FirstWeb.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student std)
        {
            string strResult = "Xin chao" + std.FullName + "-" + std.Address + "-" + std.Email + "-" + std.Phone;
            ViewBag.Thongtin = strResult;
            return View();

        }
    }
}