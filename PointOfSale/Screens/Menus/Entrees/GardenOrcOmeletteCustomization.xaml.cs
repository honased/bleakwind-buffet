/*
 * Author: Eric Honas
 * Class name: GardenOrcOmeletteCustomization.xaml.cs
 * Purpose: A component used for customizing a GardenOrcOmelette.
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Entrees
{
    /// <summary>
    /// A class that customizes the properties of a GardenOrcOmelette entree.
    /// </summary>
    public partial class GardenOrcOmeletteCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new GardenOrcOmeletteCustomization component.
        /// </summary>
        public GardenOrcOmeletteCustomization()
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
                GardenOrcOmelette goo = new GardenOrcOmelette();

                return goo;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
