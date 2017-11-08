using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProBilling.ReportGenerationLogic.Class;
using ProBilling.ReportGenerationLogic.Interface;
using ProBilling.Web.Client.Models;

namespace ProBilling.Web.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
	        IPerDaySprintActivityInputWrapper perDaySprintActivityInputWrapper = new PerDaySprintActivityResult();
	        MeetingStatus meetingStatus = new MeetingStatus();

	        perDaySprintActivityInputWrapper.UserId = "1";
	        perDaySprintActivityInputWrapper.TeamId = 1;
	        perDaySprintActivityInputWrapper.SprintId = 1;
	        perDaySprintActivityInputWrapper.Date = DateTime.Now.Date;

		   PerDaySprintActivity perDaySprintActivity = new PerDaySprintActivity(perDaySprintActivityInputWrapper,meetingStatus);
	       perDaySprintActivity.Save();


			return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
