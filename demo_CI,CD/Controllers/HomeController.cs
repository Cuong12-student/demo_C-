using demo_CI_CD.Models;
using demo_CI_CD.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demo_CI_CD.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService _messageService;

        // Tiêm (Inject) Interface vào Controller thông qua Main/DI container
        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            // Lấy thông điệp từ phần Implement
            ViewBag.ThongBao = _messageService.GetWelcomeMessage();
            return View();
        }
    }
}
