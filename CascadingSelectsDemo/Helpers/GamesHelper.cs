using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingSelectsDemo
{
    public static class GamesHelper
    {
        public static string[] SelectGames(string developer, string console)
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