using System;
using System.Web.Mvc;

namespace CascadingSelectsDemo.Controllers
{
    public class GameSystemController : Controller
    {
        // GET: GameSystem
        public ActionResult Games(string developer, string console)
        {
            string[] games = new[] { "" };
            if (!String.IsNullOrEmpty(developer) && !String.IsNullOrEmpty(console))
            {
                games = GamesHelper.SelectGames(developer, console);
                return Json(games, JsonRequestBehavior.AllowGet);
            }
            return Json(games, JsonRequestBehavior.AllowGet);
        }
    }    
}