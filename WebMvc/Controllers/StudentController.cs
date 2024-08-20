using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
namespace WebMvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student sd)
        {
            string strOutput = "Xin chao " + sd.MaSinhVien + "-" + sd.HoTen;
            ViewBag.Mess = strOutput;
            return View();
        }
    }
}