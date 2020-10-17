/*
 * Author: Eric Honas
 * Class name: OrderInformation.xaml.cs
 * Purpose: A component used for displaying the current status of the order.
 */

using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Interfaces;
using PointOfSale.Screens.Menus;
using PointOfSale.Screens.Menus.Drinks;
using PointOfSale.Screens.Menus.Entrees;
using PointOfSale.Screens.Menus.Sides;
using PointOfSale.Screens.Payment;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.Screens
{
    /// <summary>
    /// A class that allows for users to see all items on the order and the total price of the order.
    /// </summary>
    public partial class OrderInformation : UserControl, IMenuScreen
    {
        /// <summary>
        /// Creates a new OrderInformation component.
        /// </summary>
        public OrderInformation()
        {
            InitializeComponent();
        }

        public OrderComponent OrderComponent { get; set; }

        /// <summary>
        /// Changes the screen to modify the selected item in the receipt.
        /// </summary>
        /// <param name="sender">The listbox.</param>
        /// <param name="e">The event arguments.</param>
        private void ModifyItem(object sender, SelectionChangedEventArgs e)
        {
            if(sender is ListBox listBox)
            {
                if (listBox.SelectedItem == null) return;

                if(OrderComponent.screenContainer.Child is CashPaymentComponent cashPayment)
                {
                    cashPayment.Cleanup();
                }

                ItemModification customization = new ItemModification();

                CustomizationScreen screen = Helper.GetCustomizationScreen(listBox.SelectedItem as IOrderItem, out string text);
                customization.customizeItemLabel.Text = text;

                customization.customizationContainer.Child = screen;
                OrderComponent.ChangeScreen(customization);
                listBox.SelectedItem = null;

                OrderComponent.CollapseButtons(false);
            }
        }

        /// <summary>
        /// Removes the item from the order.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            if(sender is Button b)
            {
                if(b.DataContext is IOrderItem item)
                {
                    if(DataContext is Order order)
                    {
                        order.Remove(item);

                        UserControl screen = null;

                        if (OrderComponent.screenContainer.Child is ItemCustomization customization)
                        {
                            if (customization.customizationContainer.Child is CustomizationScreen scr)
                            {
                                screen = scr;
                            }
                        }
                        else if(OrderComponent.screenContainer.Child is ItemModification modifier)
                        {
                            if(modifier.customizationContainer.Child is CustomizationScreen scr)
                            {
                                screen = scr;
                            }
                        }
                        else if(OrderComponent.screenContainer.Child is MenuSelectionScreen scr)
                        {
                            screen = scr;
                        }

                        if (screen == null)
                        {
                            return;
                        }

                        if(screen.DataContext == item)
                        {
                            OrderComponent.ChangeScreen(new MenuSelectionScreen());
                        }
                        else if(item is Combo combo && (screen.DataContext == combo.Entree || screen.DataContext == combo.Drink || screen.DataContext == combo.Side))
                        {
                            OrderComponent.ChangeScreen(new MenuSelectionScreen());
                        }
                    }
                }
            }
        }
    }
}
