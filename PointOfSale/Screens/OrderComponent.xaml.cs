/*
 * Author: Eric Honas
 * Class name: OrderComponent.xaml.cs
 * Purpose: A component used for displaying all properties and actions relating to the current order.
 */

using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Interfaces;
using PointOfSale.Interfaces;
using PointOfSale.Screens.Menus;
using PointOfSale.Screens.Payment;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.Screens
{
    /// <summary>
    /// A class that allows for users to view the order and add customized items to the order.
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// The information component of the order containing properties such as the current items and total amount.
        /// </summary>
        private OrderInformation orderInformation;

        /// <summary>
        /// Creates a new order component.
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();

            screenContainer.Child = new MenuSelectionScreen() { OrderComponent = this };
            orderInformation = new OrderInformation() { OrderComponent = this };
            orderInfoContainer.Child = orderInformation;
            DataContext = new Order();
        }

        /// <summary>
        /// Changes it's main screen to a new given menu <paramref name="screen"/>. The order information screen is left alone.
        /// </summary>
        /// <param name="screen">The new screen for the Order components main view.</param>
        public void ChangeScreen(UserControl screen)
        {
            if(screen is IMenuScreen menu) menu.OrderComponent = this;
            screenContainer.Child = screen;
        }

        /// <summary>
        /// Cancels and starts a new order.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void CancelOrderClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
            ChangeScreen(new MenuSelectionScreen());
        }

        /// <summary>
        /// Starts a new order for the POS.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void CompleteOrderClicked(object sender, RoutedEventArgs e)
        {
            ChangeScreen(new PaymentOptionsComponent());
            CollapseButtons(true);
        }

        public void CollapseButtons(bool yes)
        {
            foreach (UIElement ui in buttonsGrid.Children)
            {
                ui.Visibility = (yes) ? Visibility.Collapsed : Visibility.Visible;
            }
        }
    }
}
