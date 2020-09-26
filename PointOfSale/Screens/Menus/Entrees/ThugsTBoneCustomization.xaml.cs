/*
 * Author: Eric Honas
 * Class name: ThugsTBoneCustomization.xaml.cs
 * Purpose: A component used for customizing a ThugsTBone.
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Entrees
{
    /// <summary>
    /// A class that customizes the properties of a ThugsTBone entree.
    /// </summary>
    public partial class ThugsTBoneCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new ThugsTBoneCustomization component.
        /// </summary>
        public ThugsTBoneCustomization()
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
                ThugsTBone ttb = new ThugsTBone();

                return ttb;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
