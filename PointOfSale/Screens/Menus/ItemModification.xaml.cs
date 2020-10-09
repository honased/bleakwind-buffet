/*
 * Author: Eric Honas
 * Class name: ItemModification.xaml.cs
 * Purpose: A component used for modifying a generic orderable item.
 */

using BleakwindBuffet.Data.Classes;
using PointOfSale.Interfaces;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus
{
    /// <summary>
    /// A class that allows for users to customize an item and add it to the order.
    /// </summary>
    public partial class ItemModification : UserControl, IMenuScreen
    {
        /// <summary>
        /// Creates a new ItemCustomization component.
        /// </summary>
        public ItemModification()
        {
            InitializeComponent();
        }

        public UserControl ReturnScreen { get; set; } = new MenuSelectionScreen();

        /// <summary>
        /// The parent that is holding and displaying this component.
        /// </summary>
        public OrderComponent OrderComponent { get; set; }

        /// <summary>
        /// Returns to the menu selection screen without adding the item.
        /// </summary>
        /// <param name="sender">The button that was pressed.</param>
        /// <param name="e">The event arguments associated with the press.</param>
        private void FinishClicked(object sender, RoutedEventArgs e)
        {
            OrderComponent.ChangeScreen(ReturnScreen);
        }
    }
}
