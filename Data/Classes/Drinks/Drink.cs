/*
 * Author: Eric Honas
 * Class name: Drink.cs
 * Purpose: Base Class used for representing drinks.
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// An event triggered when any property is changed.
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Size backing variable.
        /// </summary>
        protected Size size;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return ToString();
            }
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        public abstract string Description { get; }
    }
}
