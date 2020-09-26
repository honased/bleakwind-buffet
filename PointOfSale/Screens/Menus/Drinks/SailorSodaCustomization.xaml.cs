/*
 * Author: Eric Honas
 * Class name: SailorSodaCustomization.xaml.cs
 * Purpose: A component used for customizing a SailorSoda.
 */

using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Drinks
{
    /// <summary>
    /// A class that customizes the flavor, size, and properties of a SailorSoda drink.
    /// </summary>
    public partial class SailorSodaCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new SailorSodaCustomization component.
        /// </summary>
        public SailorSodaCustomization()
        {
            InitializeComponent();
            flavorChoice.SelectedIndex = 0;
            sizeChoice.SelectedIndex = 0;
        }

        /// <summary>
        /// A new instance of the ordered item with it's customized properties.
        /// </summary>
        public IOrderItem OrderedItem
        {
            get
            {
                SailorSoda ss = new SailorSoda();

                return ss;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
