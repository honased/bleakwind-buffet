/*
 * Author: Eric Honas
 * Class name: Helper.cs
 * Purpose: Provides helpful functions to the PointOfSale project.
 */

using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Screens.Menus;
using PointOfSale.Screens.Menus.Drinks;
using PointOfSale.Screens.Menus.Entrees;
using PointOfSale.Screens.Menus.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    /// <summary>
    /// A class that provides some helper functions for the overal POS.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Given an IOrderItem <paramref name="item"/>, a customization screen is generated, and the correct
        /// <paramref name="text"/> is given back.
        /// </summary>
        /// <param name="item">The menu item to generate a customization screen for.</param>
        /// <param name="text">The text that will be displayed on the screen.</param>
        /// <returns>The customization screen for the specific item.</returns>
        public static CustomizationScreen GetCustomizationScreen(IOrderItem item, out string text)
        {
            CustomizationScreen screen = null;

            text = "Unknown";

            if (item is BriarheartBurger) { screen = new BriarheartBurgerCustomization(); text = "Customize Briarheart Burger"; }
            else if (item is DoubleDraugr) { screen = new DoubleDraugrCustomization(); text = "Customize Double Draugr"; }
            else if (item is GardenOrcOmelette) { screen = new GardenOrcOmeletteCustomization(); text = "Customize Garden Orc Omelette"; }
            else if (item is PhillyPoacher) { screen = new PhillyPoacherCustomization(); text = "Customize Philly Poacher"; }
            else if (item is SmokehouseSkeleton) { screen = new SmokehouseSkeletonCustomization(); text = "Customize Smokehouse Skeleton"; }
            else if (item is ThalmorTriple) { screen = new ThalmorTripleCustomization(); text = "Customize Thalmor Triple"; }
            else if (item is ThugsTBone) { screen = new ThugsTBoneCustomization(); text = "Customize ThugsTBone"; }
            else if (item is AretinoAppleJuice) { screen = new AretinoAppleJuiceCustomization(); text = "Customize Aretino Apple Juice"; }
            else if (item is CandlehearthCoffee) { screen = new CandlehearthCoffeeCustomization(); text = "Customize Candlehearth Coffee"; }
            else if (item is MarkarthMilk) { screen = new MarkarthMilkCustomization(); text = "Customize Markarth Milk"; }
            else if (item is SailorSoda) { screen = new SailorSodaCustomization(); text = "Customize Sailor Soda"; }
            else if (item is WarriorWater) { screen = new WarriorWaterCustomization(); text = "Customize Warrior Water"; }
            else if (item is Combo) { screen = new ComboCustomization(); text = "Customize Combo"; }
            else
            {
                screen = new SideCustomization();
                if (item is DragonbornWaffleFries) text = "Customize Dragonborn Waffle Fries";
                else if (item is FriedMiraak) text = "Customize Fried Miraak";
                else if (item is MadOtarGrits) text = "Customize Mad Otar Grits";
                else if (item is VokunSalad) text = "Customize Vokun Salad";
            }

            screen.DataContext = item;

            return screen;
        }

        /// <summary>
        /// Finds the control passed to the function. Original author: Nathan Bean
        /// </summary>
        /// <typeparam name="T">Some control</typeparam>
        /// <param name="element"></param>
        /// <returns>The control we were looking for when found</returns>
        public static T GetParent<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return GetParent<T>(parent);
        }
    }
}
