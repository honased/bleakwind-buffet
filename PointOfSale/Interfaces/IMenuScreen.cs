/*
 * Author: Eric Honas
 * Class name: IMenuScreen.cs
 * Purpose: Interface used for ensuring that screens can be used for display in the Order component.
 */

using PointOfSale.Screens;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale.Interfaces
{
    /// <summary>
    /// An interface representing the properties of a menu screen.
    /// </summary>
    public interface IMenuScreen
    {
        /// <summary>
        /// The parent that is holding and displaying this component.
        /// </summary>
        Order OrderComponent { get; set; }
    }
}
