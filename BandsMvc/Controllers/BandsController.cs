using BandsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
	public class BandsController : Controller
	{
		DataService dataService;

		public BandsController()
		{
			dataService = new DataService();
		}

		[HttpGet("")]
		[HttpGet("index.php")]
		public IActionResult Index()
		{
			var band = dataService.GetAllBands();
			return View(band);
		}

		[HttpGet("detail/{id}")]
		public IActionResult Detail(int id)
		{
			var band = dataService.GetBandById(id);
			return View(band);
			//return Content($"ID:{band.Id}, Band:{band.Name}, Genre:{band.Description}");
		}
	}
}
