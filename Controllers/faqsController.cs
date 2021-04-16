using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCare01.Data;
using Microsoft.AspNetCore.Mvc;

namespace ProjectCare01.Controllers
{
	public class faqsController : Controller
	{
		private readonly ApplicationDBContext _context;
		public faqsController(ApplicationDBContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
