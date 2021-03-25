using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectCare01.Controllers
{
	public class AboutUs : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
