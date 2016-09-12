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
        public ActionResult Games(string developer, string console)
        {
            string[] games = new[] { "" };
            if (!String.IsNullOrEmpty(developer) && !String.IsNullOrEmpty(console))
            {
                games = SelectGames(developer, console);
                return Json(games, JsonRequestBehavior.AllowGet);
            }
            return Json(games, JsonRequestBehavior.AllowGet);
        }

        private string[] SelectGames(string developer, string console)
        {
            string[] games = new[] { "" };
            if (developer.Equals("james", StringComparison.OrdinalIgnoreCase))
            {
                if (console.Equals("Playstation 3", StringComparison.OrdinalIgnoreCase))
                        games = new[] { "Fifa", "Madden", "Mario" };
                else if (console.Equals("XBox One", StringComparison.OrdinalIgnoreCase))
                    games = new[] { "Doom", "NBA2K" };
                else if (console.Equals("XBox 360", StringComparison.OrdinalIgnoreCase))
                    games = new[] { "Virtua Tennis", "Bowling" };
            }
            else if (developer.Equals("stan", StringComparison.OrdinalIgnoreCase))
            {
                if (console.Equals("Playstation 3", StringComparison.OrdinalIgnoreCase))
                    games = new[] { "Tecmo Bowl", "Zelda", "Contra" };
                else if (console.Equals("XBox One", StringComparison.OrdinalIgnoreCase))
                    games = new[] { "Chess", "Archery" };
                else if (console.Equals("XBox 360", StringComparison.OrdinalIgnoreCase))
                    games = new[] { "Warcraft", "Baseball" };
            }
            return games;
        }
    }    
}