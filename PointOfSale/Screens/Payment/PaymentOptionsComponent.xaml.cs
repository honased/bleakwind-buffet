/*
 * Author: Eric Honas
 * Class name: PaymentOptionsComponent.cs
 * Purpose: A component that allows for the user to choose whether to pay 
 * for the order with cash or card.
 */

using BleakwindBuffet.Data.Classes;
using PointOfSale.Interfaces;
using PointOfSale.Screens.Menus;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Screens.Payment
{
    /// <summary>
    /// A class that allows for the user to choose what kind of transaction to use to pay for the order.
    /// </summary>
    public partial class PaymentOptionsComponent : UserControl, IMenuScreen
    {
        /// <summary>
        /// Creates a new PaymentOptionsComponent.
        /// </summary>
        public PaymentOptionsComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The parent that is holding and displaying this component.
        /// </summary>
        public OrderComponent OrderComponent { get; set; }

        /// <summary>
        /// Changes the screen to pay with cash.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void PayWithCash(object sender, RoutedEventArgs e)
        {
            OrderComponent.ChangeScreen(new CashPaymentComponent(OrderComponent));
        }

        /// <summary>
        /// Returns back to the menu selection screen.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void ReturnClicked(object sender, RoutedEventArgs e)
        {
            OrderComponent.ChangeScreen(new MenuSelectionScreen());
            OrderComponent.CollapseButtons(false);
        }

        /// <summary>
        /// Attempts to charge the card. If successful, the reciept is printed and the screen
        /// changes back to the menu selection with a new order. Otherwise, a messagebox is
        /// displayed alerting the user the error with the card.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void ChargeCard(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                CardTransactionResult result = CardReader.RunCard(order.Total);

                switch(result)
                {
                    case CardTransactionResult.Approved:
                        order.PrintReciept(true, 0.00);
                        OrderComponent.DataContext = new Order();
                        OrderComponent.ChangeScreen(new MenuSelectionScreen());
                        OrderComponent.CollapseButtons(false);
                        break;

                    case CardTransactionResult.Declined:
                        MessageBox.Show("Error: Card Declined!");
                        break;

                    case CardTransactionResult.IncorrectPin:
                        MessageBox.Show("Error: Incorrect Pin!");
                        break;

                    case CardTransactionResult.InsufficientFunds:
                        MessageBox.Show("Error: Insufficient Funds!");
                        break;

                    case CardTransactionResult.ReadError:
                        MessageBox.Show("Error: Read Error!");
                        break;

                    default:
                        throw new ArgumentException($"Error reading card. Expected a CardTransactionResult message. Got '{result}'.");
                }
            }
        }
    }
}
