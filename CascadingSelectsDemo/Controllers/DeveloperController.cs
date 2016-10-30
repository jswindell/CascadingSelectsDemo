using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingSelectsDemo.Controllers
{
    public class DeveloperController : Controller
    {
        public ActionResult Consoles(string developer)
        {
            if (developer.Equals("james", StringComparison.OrdinalIgnoreCase))
            {
                return Json(new[] { "XBox 360", "Playstation 3", "XBox One" }, JsonRequestBehavior.AllowGet);
            }
            if (developer.Equals("stan", StringComparison.OrdinalIgnoreCase))
            {
                return Json(new[] { "Playstation 3", "XBox One" }, JsonRequestBehavior.AllowGet);
            }

            return Json(new string[] {}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Games(string developer, string console)
        {
            return Json(GamesHelper.SelectGames(developer, console), JsonRequestBehavior.AllowGet);
        }
    }
}