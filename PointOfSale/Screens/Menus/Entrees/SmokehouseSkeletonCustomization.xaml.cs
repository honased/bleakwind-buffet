/*
 * Author: Eric Honas
 * Class name: SmokehouseSkeletonCustomization.xaml.cs
 * Purpose: A component used for customizing a SmokehouseSkeleton.
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using System;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus.Entrees
{
    /// <summary>
    /// A class that customizes the properties of a SmokehouseSkeleton entree.
    /// </summary>
    public partial class SmokehouseSkeletonCustomization : UserControl, ICustomizable
    {
        /// <summary>
        /// Creates a new SmokehouseSkeletonCustomization component.
        /// </summary>
        public SmokehouseSkeletonCustomization()
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
                SmokehouseSkeleton ss = new SmokehouseSkeleton();

                return ss;
            }
        }

        /// <summary>
        /// The type of item the customization is creating.
        /// </summary>
        public Type CustomizableItemType { get; set; }
    }
}
