/*
 * Author: Eric Honas
 * Class name: PhillyPoacherCustomization.xaml.cs
 * Purpose: A component used for customizing a PhillyPoacher.
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Entrees
{
    /// <summary>
    /// A class that customizes the properties of a PhillyPoacher entree.
    /// </summary>
    public partial class PhillyPoacherCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new PhillyPoacherCustomization component.
        /// </summary>
        public PhillyPoacherCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A new instance of the ordered item with it's customized properties.
        /// </summary>
        public IOrderItem OrderedItem
        {
            get
            {
                PhillyPoacher pp = new PhillyPoacher();

                return pp;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
