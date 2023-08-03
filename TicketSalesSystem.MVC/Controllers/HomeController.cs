using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicketSalesSystem.BLL.Interfaces;
using TicketSalesSystem.MVC.Models;

namespace TicketSalesSystem.MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IFlightService _flightService;

		public HomeController(ILogger<HomeController> logger, IFlightService flightService)
		{
			_logger = logger;
			_flightService = flightService;
		}

		public async Task<IActionResult> Index()
		{
			var res = await _flightService.GetAllAsync();

			return View(res);
		}

		public IActionResult Documentation()
		{
			return View();
		}

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