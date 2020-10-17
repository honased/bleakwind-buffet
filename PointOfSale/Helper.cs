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
using RoundRegister;
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

        /// <summary>
        /// Prints the details of the <paramref name="order"/> onto a reciept including the
        /// order number, date, each item with it's instructions, the price, payment
        /// method, and change owed.
        /// </summary>
        /// <param name="order">The order that was purchased.</param>
        /// <param name="card">If the user paid with cash or card</param>
        /// <param name="change">The amount of change given to the customer.</param>
        public static void PrintReciept(this Order order, bool card, double change)
        {
            RecieptPrinter.PrintLine($"Order #{order.Number}");
            RecieptPrinter.PrintLine(DateTime.Now.ToString());
            RecieptPrinter.PrintLine("");

            foreach (IOrderItem item in order)
            {
                StringBuilder name = new StringBuilder(item.Name);
                if (!RightAlign(name, String.Format("${0:0.00}", item.Price))) throw new Exception();

                RecieptPrinter.PrintLine(name.ToString());

                foreach(string instruction in item.SpecialInstructions)
                {
                    if(!instruction.Contains(" - ")) RecieptPrinter.PrintLine($" - {instruction}");
                    else RecieptPrinter.PrintLine($"   {instruction}");
                }
            }

            RecieptPrinter.PrintLine("");

            StringBuilder aligner = new StringBuilder();
            aligner.Append("Subtotal:");
            RightAlign(aligner, String.Format("${0:0.00}", order.Subtotal));
            RecieptPrinter.PrintLine(aligner.ToString());

            aligner.Clear();
            aligner.Append("Tax:");
            RightAlign(aligner, String.Format("${0:0.00}", order.Tax));
            RecieptPrinter.PrintLine(aligner.ToString());

            aligner.Clear();
            aligner.Append("Total:");
            RightAlign(aligner, String.Format("${0:0.00}", order.Total));
            RecieptPrinter.PrintLine(aligner.ToString());

            RecieptPrinter.PrintLine("");
            RecieptPrinter.PrintLine("Payment Method: " + ((card) ? "Card" : "Cash"));
            RecieptPrinter.PrintLine(String.Format("Change Owed: ${0:0.00}", change));

            RecieptPrinter.CutTape();
        }

        /// <summary>
        /// Given the <paramref name="sb"/>, the method attempts to append
        /// the given <paramref name="text"/> onto the StringBuilder while
        /// right aligning it so that it will always end at the 40 char mark.
        /// If it is impossible to do so, the method will return false. Otherwise,
        /// it will return true.
        /// </summary>
        /// <param name="sb">The stringbuild with the original text.</param>
        /// <param name="text">The text to be appended and right aligned.</param>
        /// <returns>If the operation was successful or not.</returns>
        private static bool RightAlign(StringBuilder sb, string text)
        {
            if (sb.Length + text.Length >= 40) return false;

            int target = 40 - text.Length - sb.Length;

            for(int i = 0; i < target; i++)
            {
                sb.Append(" ");
            }

            sb.Append(text);

            return true;
        }
    }
}
