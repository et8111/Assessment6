using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLHOLIDAYPARTY.Models;

namespace QLHOLIDAYPARTY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RSVP(Party party)
        {
            return View(party);
        }

        public ActionResult Dish(FOOD food)
        {
            return View(food);
        }

        public ActionResult Done(Party party)
        {
            return View(party);
        }
        public ActionResult Done1(FOOD food)
        {
            return View(food);
        }
    }
}