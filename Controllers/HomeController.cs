using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectCare01.Models;

using System.Net;
using System.Net.Mail;

namespace ProjectCare01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
        [HttpPost]
        public IActionResult Concern(Concern record)
        {
            using (MailMessage mail = new MailMessage("benilde.web.development@gmail.com", record.Email))
            {
                mail.Subject = record.OrderNo;

                string message = "Hello," + record.Name + "!<br/><br/>" +
                    "We have received your inquiry. Here are the details: <br/><br/>" +
                    "Contact Number: <strong>" + record.ContactNo + "</strong><br/>" +
                    "Message : <br/><strong>" + record.Problem + "</strong><br/>" +
                    "Please wait for our reply. Thank you!";
                mail.Body = record.Problem;
                mail.IsBodyHtml = true;

                using(SmtpClient smtp = new SmtpClient())
				{
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred =
                        new NetworkCredential("benilde.wed.development@gmail.com", "TeamProjectCare01");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mail);
                    ViewBag.Message = "Inquiry Sent.";
				}

            }

            return View();
        }
    }
}
