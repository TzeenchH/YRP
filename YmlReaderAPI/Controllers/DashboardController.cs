using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YmlReaderAPI.Models;

namespace YmlReaderAPI.Controllers
{
	[ApiController]
	[Route("Dashboard")]
	public class DashboardController : Controller
	{
		public DashboardController()
		{

		}

		[ActionName("AllYmls")]
		[HttpGet("AllYmls")]
		public IEnumerable<int> GetYmls()
		{
			int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			return test;
		}

		[ActionName("YmlDoc")]
		[HttpGet("YmlDoc")]
		public IEnumerable<BaseModelTest> GetDocs()
		{
			var model = new BaseModelTest[] { new BaseModelTest() { Id = 1, Name = "Test", Surname = "Test1" } };
			return model;
		}
	}
}
