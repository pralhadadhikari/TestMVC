using Microsoft.AspNetCore.Mvc;

namespace TestMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test()
        {            
            var data = "This is test Data";
            ViewBag.Mydata = data;
            return View();
        }
    }
}
