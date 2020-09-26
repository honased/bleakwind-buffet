/*
 * Author: Eric Honas
 * Class name: WarriorWaterCustomization.xaml.cs
 * Purpose: A component used for customizing a WarriorWater.
 */

using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Drinks
{
    /// <summary>
    /// A class that customizes the size and properties of a WarriorWater drink.
    /// </summary>
    public partial class WarriorWaterCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new WarriorWaterCustomization component.
        /// </summary>
        public WarriorWaterCustomization()
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
                WarriorWater ww = new WarriorWater();

                return ww;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
