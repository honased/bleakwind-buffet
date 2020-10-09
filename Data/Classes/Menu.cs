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
    }
}
