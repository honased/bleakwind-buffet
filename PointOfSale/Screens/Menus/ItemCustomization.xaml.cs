/*
 * Author: Eric Honas
 * Class name: ItemCustomization.xaml.cs
 * Purpose: A component used for customizing an generic orderable item.
 */

using PointOfSale.Interfaces;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus
{
    /// <summary>
    /// A class that allows for users to customize an item and add it to the order.
    /// </summary>
    public partial class ItemCustomization : UserControl, IMenuScreen
    {
        /// <summary>
        /// Creates a new ItemCustomization component.
        /// </summary>
        public ItemCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The parent that is holding and displaying this component.
        /// </summary>
        public Order OrderComponent { get; set; }

        /// <summary>
        /// Adds the customized item to the order and returns to the menu selection screen.
        /// </summary>
        /// <param name="sender">The button that was pressed.</param>
        /// <param name="e">The event arguments associated with the press.</param>
        /// <exception cref="System.InvalidOperationException">Thrown if there is no actual customization component.</exception>
        private void AddItemClicked(object sender, RoutedEventArgs e)
        {
            CustomizationScreen customization = customizationContainer.Child as CustomizationScreen;

            if(customization == null)
            {
                throw new InvalidOperationException("Cannot add the item when no customization has been set.");
            }

            OrderComponent.AddItem(customization.OrderedItem);

            OrderComponent.ChangeScreen(new MenuSelectionScreen());
        }

        /// <summary>
        /// Returns to the menu selection screen without adding the item.
        /// </summary>
        /// <param name="sender">The button that was pressed.</param>
        /// <param name="e">The event arguments associated with the press.</param>
        private void CancelClicked(object sender, RoutedEventArgs e)
        {
            OrderComponent.ChangeScreen(new MenuSelectionScreen());
        }
    }
}
