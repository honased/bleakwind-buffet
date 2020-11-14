/*
 * Author: Eric Honas
 * Class name: Entree.cs
 * Purpose: Base Class used for representing entrees.
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// An event triggered when any property is changed.
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree
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
