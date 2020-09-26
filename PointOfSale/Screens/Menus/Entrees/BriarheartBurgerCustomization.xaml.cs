/*
 * Author: Eric Honas
 * Class name: BriarheartBurgerCustomization.xaml.cs
 * Purpose: A component used for customizing a BriarheartBurger.
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Entrees
{
    /// <summary>
    /// A class that customizes a BriarheartBurger entree.
    /// </summary>
    public partial class BriarheartBurgerCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new BriarheartBurgerCustomization component.
        /// </summary>
        public BriarheartBurgerCustomization()
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
                BriarheartBurger bb = new BriarheartBurger();

                return bb;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
