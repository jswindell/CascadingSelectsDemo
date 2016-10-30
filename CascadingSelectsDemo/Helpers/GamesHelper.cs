﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingSelectsDemo
{
    public static class GamesHelper
    {
        public static string[] SelectGames(string developer, string console)
        {            
            if (developer.Equals("james", StringComparison.OrdinalIgnoreCase))
            {
                if (console.Equals("Playstation 3", StringComparison.OrdinalIgnoreCase))
                    return new[] { "Fifa", "Madden", "Mario" };
                else if (console.Equals("XBox One", StringComparison.OrdinalIgnoreCase))
                    return new[] { "Doom", "NBA2K" };
                else 
                    return new[] { "Virtua Tennis", "Bowling" };
            }
            else if (developer.Equals("stan", StringComparison.OrdinalIgnoreCase))
            {
                if (console.Equals("Playstation 3", StringComparison.OrdinalIgnoreCase))
                    return new[] { "Tecmo Bowl", "Zelda", "Contra" };
                else if (console.Equals("XBox One", StringComparison.OrdinalIgnoreCase))
                    return new[] { "Chess", "Archery" };
                else 
                    return new[] { "Warcraft", "Baseball" };
            }
            else
                return new[] { "" };            
        }
    }
}