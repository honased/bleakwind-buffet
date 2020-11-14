/*
 * Author: Eric Honas
 * Interface name: Drink.cs
 * Purpose: Interface used for ensuring orderable items have certain properties.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Interfaces
{
    /// <summary>
    /// An interface representing the properties of orderable items.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the item.
        /// </summary>
        /// <value>
        /// In US dollars.
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories in the item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The list of special instructions.
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// The name of the order item.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The description of the order item.
        /// </summary>
        string Description { get; }
    }
}
