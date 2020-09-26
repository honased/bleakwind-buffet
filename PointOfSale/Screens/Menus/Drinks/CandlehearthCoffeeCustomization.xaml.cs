/*
 * Author: Eric Honas
 * Class name: CandlehearthCoffeeCustomization.xaml.cs
 * Purpose: A component used for customizing a CandlehearthCoffee.
 */

using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Drinks
{
    /// <summary>
    /// A class that customizes the size and properties of a CandlehearthCoffee drink.
    /// </summary>
    public partial class CandlehearthCoffeeCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new CandlehearthCoffeeCustomization component.
        /// </summary>
        public CandlehearthCoffeeCustomization()
        {
            InitializeComponent();
            sizeChoice.SelectedIndex = 0;
        }

        /// <summary>
        /// A new instance of the ordered item with it's customized properties.
        /// </summary>
        public IOrderItem OrderedItem
        {
            get
            {
                CandlehearthCoffee cc = new CandlehearthCoffee();

                return cc;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
