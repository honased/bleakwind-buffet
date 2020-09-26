/*
 * Author: Eric Honas
 * Class name: ICustomizable.cs
 * Purpose: Interface used for ensuring that certain components are used to customize items.
 */

using BleakwindBuffet.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Interfaces
{
    /// <summary>
    /// An interface representing the properties of components that can customize an item.
    /// </summary>
    public interface ICustomizable
    {
        /// <summary>
        /// A new instance of the ordered item with it's customized properties.
        /// </summary>
        IOrderItem OrderedItem { get; }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        Type CustomizableItemType { get; set; }
    }
}
