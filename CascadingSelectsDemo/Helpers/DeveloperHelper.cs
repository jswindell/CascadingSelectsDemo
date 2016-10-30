using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingSelectsDemo
{
    public static class DeveloperHelper
    {
        private static readonly string[] EmptyStringArray = new string[0];

        public static string[] GetConsoles(string developer)
        {
            if (developer.Equals("james", StringComparison.OrdinalIgnoreCase))
            {
                return new[] { "XBox 360", "Playstation 3", "XBox One" };
            }

            if (developer.Equals("stan", StringComparison.OrdinalIgnoreCase))
            {
                return new[] { "Playstation 3", "XBox One" };
            }

            return EmptyStringArray;
        }

        public static string[] GetConsoleGames(string developer, string console)
        {
            if (developer.Equals("james", StringComparison.OrdinalIgnoreCase))
            {
                if (console.Equals("Playstation 3", StringComparison.OrdinalIgnoreCase))
                    return new[] { "Fifa", "Madden", "Mario" };
                else if (console.Equals("XBox One", StringComparison.OrdinalIgnoreCase))
                    return new[] { "Doom", "NBA2K" };
            }
            else if (developer.Equals("stan", StringComparison.OrdinalIgnoreCase))
            {
                if (console.Equals("Playstation 3", StringComparison.OrdinalIgnoreCase))
                    return new[] { "Tecmo Bowl", "Zelda", "Contra" };
                else if (console.Equals("XBox One", StringComparison.OrdinalIgnoreCase))
                    return new[] { "Chess", "Archery" };
            }

            return EmptyStringArray;
        }
    }
}