/*
 * Author: Eric Honas
 * Class name: Menu.cs
 * Purpose: Class used for representing the menu of all items.
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data.Classes
{
    /// <summary>
    /// A class that represents a menu and allows for the retrieval of all items.
    /// </summary>
    public static class Menu
    {

        /// <summary>
        /// Get all entrees on the menu.
        /// </summary>
        /// <returns>Each entree as an IOrderItem.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            yield return new BriarheartBurger();
            yield return new DoubleDraugr();
            yield return new GardenOrcOmelette();
            yield return new PhillyPoacher();
            yield return new SmokehouseSkeleton();
            yield return new ThalmorTriple();
            yield return new ThugsTBone();
        }

        /// <summary>
        /// Get all drinks on the menu.
        /// </summary>
        /// <returns>Each drink as an IOrderItem.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            foreach(Drink drink in GetAllDrinkSizes<AretinoAppleJuice>())
            {
                yield return drink;
            }

            foreach (Drink drink in GetAllDrinkSizes<CandlehearthCoffee>())
            {
                yield return drink;
            }

            foreach (Drink drink in GetAllDrinkSizes<MarkarthMilk>())
            {
                yield return drink;
            }

            // Blackberry
            foreach (SailorSoda drink in GetAllDrinkSizes<SailorSoda>())
            {
                drink.Flavor = SodaFlavor.Blackberry;
                yield return drink;
            }

            // Cherry
            foreach (SailorSoda drink in GetAllDrinkSizes<SailorSoda>())
            {
                drink.Flavor = SodaFlavor.Cherry;
                yield return drink;
            }

            // Grapefruit
            foreach (SailorSoda drink in GetAllDrinkSizes<SailorSoda>())
            {
                drink.Flavor = SodaFlavor.Grapefruit;
                yield return drink;
            }

            // Lemon
            foreach (SailorSoda drink in GetAllDrinkSizes<SailorSoda>())
            {
                drink.Flavor = SodaFlavor.Lemon;
                yield return drink;
            }

            // Peach
            foreach (SailorSoda drink in GetAllDrinkSizes<SailorSoda>())
            {
                drink.Flavor = SodaFlavor.Peach;
                yield return drink;
            }

            // Watermelon
            foreach (SailorSoda drink in GetAllDrinkSizes<SailorSoda>())
            {
                drink.Flavor = SodaFlavor.Watermelon;
                yield return drink;
            }

            foreach (Drink drink in GetAllDrinkSizes<WarriorWater>())
            {
                yield return drink;
            }
        }

        /// <summary>
        /// Gets all sides on the menu.
        /// </summary>
        /// <returns>Each side as an IOrderItem.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            foreach(Side side in GetAllSideSizes<DragonbornWaffleFries>())
            {
                yield return side;
            }

            foreach (Side side in GetAllSideSizes<FriedMiraak>())
            {
                yield return side;
            }

            foreach (Side side in GetAllSideSizes<MadOtarGrits>())
            {
                yield return side;
            }

            foreach (Side side in GetAllSideSizes<VokunSalad>())
            {
                yield return side;
            }
        }

        /// <summary>
        /// Gets every item on the menu.
        /// </summary>
        /// <returns>Every item as an IOrderItem.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            foreach(Entree e in Entrees())
            {
                yield return e;
            }

            foreach (Side s in Sides())
            {
                yield return s;
            }

            foreach (Drink d in Drinks())
            {
                yield return d;
            }
        }

        /// <summary>
        /// A helper method that returns the given drink type as the different sizes.
        /// </summary>
        /// <typeparam name="T">The type of drink.</typeparam>
        /// <returns>The type of drink in each size.</returns>
        private static IEnumerable<T> GetAllDrinkSizes<T>() where T : Drink, new()
        {
            T drinkS = new T();
            drinkS.Size = Size.Small;
            yield return drinkS;

            T drinkM = new T();
            drinkM.Size = Size.Medium;
            yield return drinkM;

            T drinkL = new T();
            drinkL.Size = Size.Large;
            yield return drinkL;
        }

        /// <summary>
        /// A helper method that returns the given side type as the different sizes.
        /// </summary>
        /// <typeparam name="T">The type of side.</typeparam>
        /// <returns>The type of side in each size.</returns>
        private static IEnumerable<T> GetAllSideSizes<T>() where T : Side, new()
        {
            T sideS = new T();
            sideS.Size = Size.Small;
            yield return sideS;

            T sideM = new T();
            sideM.Size = Size.Medium;
            yield return sideM;

            T sideL = new T();
            sideL.Size = Size.Large;
            yield return sideL;
        }

        /// <summary>
        /// Filters the given <paramref name="items"/> by the given <paramref name="searchTerms"/>.
        /// </summary>
        /// <param name="items">The items to filter.</param>
        /// <param name="searchTerms">The terms to use for filtering.</param>
        /// <returns>The filtered items.</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string searchTerms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (searchTerms == null) return items;
            if (items == null) return null;

            foreach(IOrderItem item in items)
            {
                string name = item.Name;
                if (item is SailorSoda) name = "Sailor Soda";
                if(name != null && name.ToLower().Contains(searchTerms.ToLower()))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the given <paramref name="items"/> by what <paramref name="categories"/> are checked.
        /// </summary>
        /// <param name="items">The items to filter</param>
        /// <param name="categories">The categories to use for filtering</param>
        /// <returns>The filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (categories == null || categories.Count() == 0) return items;
            if (items == null) return null;

            foreach (IOrderItem item in items)
            {
                if (item is Entree && categories.Contains("Entree")) results.Add(item);
                else if (item is Drink && categories.Contains("Drink")) results.Add(item);
                else if (item is Side && categories.Contains("Side")) results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Filters the given <paramref name="items"/> by checking if the calories fall in the bounds of 
        /// <paramref name="min"/> and <paramref name="max"/>.
        /// </summary>
        /// <param name="items">The items to filter</param>
        /// <param name="min">The minimum amount of calories</param>
        /// <param name="max">The maximum amount of calories</param>
        /// <returns>The filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            if (items == null) return null;

            List<IOrderItem> results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max) results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Filters the given <paramref name="items"/> by checking if the price fall in the bounds of 
        /// <paramref name="min"/> and <paramref name="max"/>.
        /// </summary>
        /// <param name="items">The items to filter</param>
        /// <param name="min">The minimum price</param>
        /// <param name="max">The maximum price</param>
        /// <returns>The filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            if (items == null) return null;

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max) results.Add(item);
            }

            return results;
        }
    }
}
