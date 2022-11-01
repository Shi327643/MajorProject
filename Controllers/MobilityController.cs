using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBookingProject.ViewModel;

namespace TravelBookingProject.Controllers
{
    public class MobilityController : Controller
    {
        // GET: Mobility
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GlobalMobilityForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GlobalMobilityForm(MobilityViewModel mobilityViewModel)
        {
            return View();
        }
    }
}