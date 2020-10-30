/*
 * Author: Eric Honas
 * Class name: Index.cshtml.cs
 * Purpose: Class used for representing the model behind the index page.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    /// <summary>
    /// A class that acts as a model for the Index page.
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Creates a new IndexModel.
        /// </summary>
        /// <param name="logger">A logger.</param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// A method that runs on a get request.
        /// </summary>
        public void OnGet()
        {

        }

        /// <summary>
        /// Gets all the entrees in the menu.
        /// </summary>
        public IEnumerable<Entree> Entrees
        {
            get
            {
                foreach(Entree entree in Menu.Entrees())
                {
                    yield return entree;
                }
            }
        }

        /// <summary>
        /// Gets all the drinks in the menu.
        /// </summary>
        public IEnumerable<Drink> Drinks
        {
            get
            {
                foreach (Drink drink in Menu.Drinks())
                {
                    yield return drink;
                }
            }
        }

        /// <summary>
        /// Gets all the sides in the menu.
        /// </summary>
        public IEnumerable<Side> Sides
        {
            get
            {
                foreach (Side side in Menu.Sides())
                {
                    yield return side;
                }
            }
        }

        /// <summary>
        /// Gets all the soda flavors a Sailor soda
        /// can have.
        /// </summary>
        public IEnumerable<string> SodaFlavors
        {
            get
            {
                foreach(string s in Enum.GetNames(typeof(SodaFlavor)))
                {
                    yield return s;
                }
            }
        }
    }
}
