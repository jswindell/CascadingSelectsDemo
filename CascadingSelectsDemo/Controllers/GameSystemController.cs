using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingSelectsDemo.Controllers
{
    public class GameSystemController : Controller
    {
        // GET: GameSystem
        public ActionResult Games(string console)
        {
            if (!String.IsNullOrEmpty(console) && console.Equals("Playstation 3", StringComparison.OrdinalIgnoreCase))
            {
                return Json(new[] { "Fifa", "Madden", "Mario" }, JsonRequestBehavior.AllowGet);
            }

            return Json(new[] { "" }, JsonRequestBehavior.AllowGet);
        }
    }
}