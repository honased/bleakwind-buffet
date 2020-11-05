/*
 * Author: Eric Honas
 * Class name: About.cshtml.cs
 * Purpose: Class used for representing the model behind the about page.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    /// <summary>
    /// A class that acts as a model for the about page.
    /// </summary>
    public class AboutModel : PageModel
    {
        /// <summary>
        /// A method that runs on a get request.
        /// </summary>
        public void OnGet()
        {
        }
    }
}
