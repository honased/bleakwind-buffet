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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

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

        public string[] ItemTypes
        {
            get => new string[]
            {
                "Entree",
                "Drink",
                "Side"
            };
        }
    }
}
