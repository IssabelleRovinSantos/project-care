using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ProjectCare01.Data;
using ProjectCare01.Models;

namespace ProjectCare01.Controllers
{
    public class ConcernController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ConcernController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Concern record)
        {
            var concern = new Concern()
            {
                Name = record.Name,
                ContactNo = record.ContactNo,
                Email = record.Email,
                OrderNo = record.OrderNo,
                Problem = record.Problem
            };

            _context.Concerns.Add(concern);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
