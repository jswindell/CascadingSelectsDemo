using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingSelectsDemo.Controllers
{
    [RouteArea("api/v1")]
    [RoutePrefix("developer")]
    public class DeveloperApiController : Controller
    {
        [Route("{developer}/consoles")]
        public ActionResult Consoles(string developer)
        {
            return Json(DeveloperHelper.GetConsoles(developer), JsonRequestBehavior.AllowGet);
        }

        [Route("{developer}/consoles/{console}")]
        public ActionResult Games(string developer, string console)
        {
            return Json(DeveloperHelper.GetConsoleGames(developer, console), JsonRequestBehavior.AllowGet);
        }
    }
}