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
            return Json(DeveloperHelper.GetConsoles(developer), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Games(string developer, string console)
        {
            return Json(DeveloperHelper.SelectGames(developer, console), JsonRequestBehavior.AllowGet);
        }
    }
}