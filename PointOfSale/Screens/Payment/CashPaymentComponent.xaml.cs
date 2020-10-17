/*
 * Author: Eric Honas
 * Class name: CashPaymentComponent.cs
 * Purpose: A component used for allowing the user to take customer's cash and give back the correct amount of change
 * based on the cost of the order and how much money is in the Cash Register.
 */

using BleakwindBuffet.Data.Classes;
using PointOfSale.Interfaces;
using PointOfSale.Screens.Menus;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
    /// A class that allows for the POS user to complete the transaction with cash.
    /// </summary>
    public partial class CashPaymentComponent : UserControl, IMenuScreen
    {
        /// <summary>
        /// Creates a new CashPaymentComponent and sets the DataContext to a new RegisterViewModel.
        /// </summary>
        public CashPaymentComponent()
        {
            InitializeComponent();
            var rvm = new RegisterViewModel();

            DataContext = rvm;

            if(OrderComponent != null && OrderComponent.DataContext is Order order)
            {
                order.PropertyChanged += OnPropertyChanged;

                rvm.MakeChange(order.Total);
            }

            rvm.PropertyChanged += OnPropertyChanged;
        }

        /// <summary>
        /// Creates a new CashPaymentComponent and sets the DataContext to a new RegisterViewModel.
        /// </summary>
        public CashPaymentComponent(OrderComponent orderComponent)
        {
            InitializeComponent();
            var rvm = new RegisterViewModel();

            OrderComponent = orderComponent;

            DataContext = rvm;

            if (OrderComponent != null && OrderComponent.DataContext is Order order)
            {
                order.PropertyChanged += OnPropertyChanged;

                rvm.MakeChange(order.Total);
            }

            rvm.PropertyChanged += OnPropertyChanged;
        }

        /// <summary>
        /// Updates the change to be given back whenever the customer changes how much
        /// money they are giving.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void UpdateChange(object sender, RoutedEventArgs e)
        {
            if(DataContext is RegisterViewModel rvm && OrderComponent.DataContext is Order order)
            {
                rvm.MakeChange(order.Total);
            }
        }

        /// <summary>
        /// When the customer has provided enough funds and change can be made, the order
        /// is finalized, and a new order is started.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void FinalizeOrder(object sender, RoutedEventArgs e)
        {
            if (DataContext is RegisterViewModel rvm)
            {
                if(OrderComponent.DataContext is Order order)
                {
                    order.PrintReciept(false, rvm.ChangeOwed);
                }

                rvm.FinalizeOrder();
                Cleanup();
                OrderComponent.CollapseButtons(false);
                OrderComponent.ChangeScreen(new MenuSelectionScreen());
                OrderComponent.DataContext = new Order();
            }
        }

        /// <summary>
        /// Cancels the sale but does not cancel the order. In effect, it just returns
        /// the POS back to the selection screen while keeping the same order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSale(object sender, RoutedEventArgs e)
        {
            OrderComponent.CollapseButtons(false);
            OrderComponent.ChangeScreen(new MenuSelectionScreen());
            Cleanup();
        }

        /// <summary>
        /// Updates the view whenever the RegisterViewModel or Order changes.
        /// </summary>
        /// <param name="sender">The class that was modified.</param>
        /// <param name="e">The event arguments.</param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(sender is RegisterViewModel rvm && e.PropertyName == "CanMakeChange" && !rvm.CanMakeChange)
            {
                MessageBox.Show("Not enough money in the register to make change!");
            }
            else if(sender is Order order && e.PropertyName == "Total" && DataContext is RegisterViewModel rvmContext)
            {
                rvmContext.MakeChange(order.Total);
            }
        }

        /// <summary>
        /// Cleanups the component by deattaching its event listeners.
        /// </summary>
        public void Cleanup()
        {
            if (OrderComponent != null && OrderComponent.DataContext is Order order)
            {
                order.PropertyChanged -= OnPropertyChanged;
            }

            if (DataContext is RegisterViewModel rvm)
            {
                rvm.PropertyChanged -= OnPropertyChanged;
            }
        }

        /// <summary>
        /// The parent that is holding and displaying this component.
        /// </summary>
        public OrderComponent OrderComponent { get; set; }
    }
}
