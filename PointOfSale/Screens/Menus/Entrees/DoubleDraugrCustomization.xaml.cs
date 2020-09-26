/*
 * Author: Eric Honas
 * Class name: DoubleDraugrCustomization.xaml.cs
 * Purpose: A component used for customizing a DoubleDraugr.
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Entrees
{
    /// <summary>
    /// A class that customizes a DoubleDraugr entree.
    /// </summary>
    public partial class DoubleDraugrCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new DoubleDraugrCustomization component.
        /// </summary>
        public DoubleDraugrCustomization()
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
                DoubleDraugr dd = new DoubleDraugr();

                return dd;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
