/*
 * Author: Eric Honas
 * Class name: ThalmorTripleCustomization.xaml.cs
 * Purpose: A component used for customizing a ThalmorTriple.
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Entrees
{
    /// <summary>
    /// A class that customizes the properties of a ThalmorTriple entree.
    /// </summary>
    public partial class ThalmorTripleCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new ThalmorTripleCustomization component.
        /// </summary>
        public ThalmorTripleCustomization()
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
                ThalmorTriple tt = new ThalmorTriple();

                return tt;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
