/*
 * Author: Eric Honas
 * Class name: Side.cs
 * Purpose: Base Class used for representing sides.
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
