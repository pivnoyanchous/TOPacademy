using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInfoService _infoService;

        public HomeController(IInfoService infoService)
        {
            _infoService = infoService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _infoService.GetMessage();
            return View();
        }
    }
}
