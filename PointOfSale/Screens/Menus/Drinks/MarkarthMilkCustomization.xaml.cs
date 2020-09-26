/*
 * Author: Eric Honas
 * Class name: MarkarthMilkCustomization.xaml.cs
 * Purpose: A component used for customizing a MarkarthMilk.
 */

using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Drinks
{
    /// <summary>
    /// A class that customizes the size and properties of a MarkarthMilk drink.
    /// </summary>
    public partial class MarkarthMilkCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new MarkarthMilkCustomization component.
        /// </summary>
        public MarkarthMilkCustomization()
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
                MarkarthMilk mm = new MarkarthMilk();

                return mm;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
