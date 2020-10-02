/*
 * Author: Eric Honas
 * Class name: CustomizationScreen.cs
 * Purpose: A class used for customizing the properties of an item.
 */

using BleakwindBuffet.Data.Interfaces;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus
{
    /// <summary>
    /// A class that allows for a specific item to be customized.
    /// </summary>
    public class CustomizationScreen : UserControl
    {
        /// <summary>
        /// The ordered item with it's properties customized.
        /// </summary>
        public virtual IOrderItem OrderedItem
        {
            get
            {
                return DataContext as IOrderItem;
            }
        }
    }
}
