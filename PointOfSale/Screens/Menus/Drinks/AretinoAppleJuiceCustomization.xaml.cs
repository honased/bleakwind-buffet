/*
 * Author: Eric Honas
 * Class name: AretinoAppleJuiceCustomization.xaml.cs
 * Purpose: A component used for customizing an AretinoAppleJuice.
 */

using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Drinks
{
    /// <summary>
    /// A class that customizes the size and properties of an AretinoAppleJuice drink.
    /// </summary>
    public partial class AretinoAppleJuiceCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new AretinoAppleJuiceCustomization component.
        /// </summary>
        public AretinoAppleJuiceCustomization()
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
                AretinoAppleJuice aj = new AretinoAppleJuice();

                return aj;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
