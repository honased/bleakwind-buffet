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
using BleakwindBuffet.Data.Interfaces;
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
        /// The menu items to display on the main page.
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; set; }

        /// <summary>
        /// Gets all the entrees in the menu.
        /// </summary>
        public IEnumerable<Entree> Entrees
        {
            get
            {
                foreach(IOrderItem item in MenuItems)
                {
                    if (item is Entree entree) yield return entree;
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
                bool usedSailorSmall = false, usedSailorMedium = false, usedSailorLarge = false;
                foreach (IOrderItem item in MenuItems)
                {
                    if(item is SailorSoda ss)
                    {
                        if (ss.Size == Size.Small)
                        {
                            if(!usedSailorSmall) usedSailorSmall = true;
                            else continue;
                        }

                        if (ss.Size == Size.Medium)
                        {
                            if (!usedSailorMedium) usedSailorMedium = true;
                            else continue;
                        }

                        if (ss.Size == Size.Large)
                        {
                            if (!usedSailorLarge) usedSailorLarge = true;
                            else continue;
                        }
                    }
                    if (item is Drink drink) yield return drink;
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
                foreach (IOrderItem item in MenuItems)
                {
                    if (item is Side side) yield return side;
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

        /// <summary>
        /// The different types a menu item can be.
        /// </summary>
        public string[] AllItemTypes
        {
            get => new string[]
            {
                "Entree",
                "Drink",
                "Side"
            };
        }

        /// <summary>
        /// The search terms for filtering.
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The item types for filtering.
        /// </summary>
        public string[] ItemTypes { get; set; }

        /// <summary>
        /// The minimum calories for filtering.
        /// </summary>
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories for filtering.
        /// </summary>
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum price for filtering.
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum price for filtering.
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// When called, filters the menu items and keeps the filters the same way.
        /// </summary>
        public void OnGet(string SearchTerms, string[] ItemTypes, int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            MenuItems = Menu.Search(Menu.FullMenu(), SearchTerms);
            MenuItems = Menu.FilterByCategory(MenuItems, ItemTypes);
            MenuItems = Menu.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);

            this.SearchTerms = SearchTerms;
            this.ItemTypes = ItemTypes;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
        }
    }
}
