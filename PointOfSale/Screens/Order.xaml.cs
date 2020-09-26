/*
 * Author: Eric Honas
 * Class name: Order.xaml.cs
 * Purpose: A component used for displaying all properties and actions relating to the current order.
 */

using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using PointOfSale.Screens;
using PointOfSale.Screens.Menus;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.Screens
{
    /// <summary>
    /// A class that allows for users to view the order and add customized items to the order.
    /// </summary>
    public partial class Order : UserControl
    {
        /// <summary>
        /// The information component of the order containing properties such as the current items and total amount.
        /// </summary>
        private OrderInformation orderInformation;

        /// <summary>
        /// Creates a new order component.
        /// </summary>
        public Order()
        {
            InitializeComponent();

            screenContainer.Child = new MenuSelectionScreen() { OrderComponent = this };

            orderInformation = new OrderInformation();

            orderInfoContainer.Child = orderInformation;
        }

        /// <summary>
        /// Changes it's main screen to a new given menu <paramref name="screen"/>. The order information screen is left alone.
        /// </summary>
        /// <param name="screen">The new screen for the Order components main view.</param>
        public void ChangeScreen(IMenuScreen screen)
        {
            screen.OrderComponent = this;
            screenContainer.Child = (UIElement)screen;
        }

        /// <summary>
        /// Adds a new <paramref name="item"/> to the order and updates the order information component.
        /// </summary>
        /// <param name="item">The item to add to the order.</param>
        public void AddItem(IOrderItem item)
        {
            orderInformation.AddItem(item);
        }
    }
}
