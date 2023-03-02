using Cw12.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cw12.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		[Route("Home/Index")]
		public IActionResult Index()
		{
			return View();
		}
		[Route("Test")]
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}