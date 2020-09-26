/*
 * Author: Eric Honas
 * Class name: SideCustomization.xaml.cs
 * Purpose: A component used for customizing a generic side.
 */

using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Sides
{
    /// <summary>
    /// A class that customizes the size of a side.
    /// </summary>
    public partial class SideCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new SideCustomization component.
        /// </summary>
        public SideCustomization()
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
                return Activator.CreateInstance(CustomizableItemType) as IOrderItem;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
