﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameForIT.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public string ChooseGame()
        {
            string gameToPlay = string.Empty;

            return gameToPlay;
        }
    }
}
