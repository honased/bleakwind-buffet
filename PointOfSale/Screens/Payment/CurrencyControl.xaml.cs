/*
 * Author: Eric Honas
 * Class name: CurrencyControl.cs
 * Purpose: A component that allows for the properties of a type of currency in the cash drawer.
 * to be displayed and modified.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// A class that allows the POS user to view and modify a specific currency in the cash drawer.
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        /// <summary>
        /// Creates a new CurrencyControl component.
        /// </summary>
        public CurrencyControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The metadata for the change dependency property.
        /// </summary>
        static FrameworkPropertyMetadata changeMetadata = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender);
        
        /// <summary>
        /// The metadata for the customer amount dependency property.
        /// </summary>
        static FrameworkPropertyMetadata customerMetadata = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.AffectsRender, HandleCustomerAmountChanged);

        /// <summary>
        /// A dependency property representing how much change to give back to the customer.
        /// </summary>
        public static DependencyProperty ChangeProperty = DependencyProperty.Register("Change", typeof(int), typeof(CurrencyControl), changeMetadata);
        
        /// <summary>
        /// A dependency property representing how much of the currency the customer has paid with.
        /// </summary>
        public static DependencyProperty CustomerAmountProperty = DependencyProperty.Register("CustomerAmount", typeof(int), typeof(CurrencyControl), customerMetadata);
        
        /// <summary>
        /// A dependency property representing what the currency is.
        /// </summary>
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl), new PropertyMetadata(""));

        /// <summary>
        /// The amount of the type of currency from the customer.
        /// </summary>
        public int CustomerAmount
        {
            get => (int)GetValue(CustomerAmountProperty);
            set => SetValue(CustomerAmountProperty, value);
        }

        /// <summary>
        /// The amount of the type of currency to give back to the customer.
        /// </summary>
        public int Change
        {
            get => (int)GetValue(ChangeProperty);
            set => SetValue(ChangeProperty, value);
        }

        /// <summary>
        /// The type of currency this control is bound to.
        /// </summary>
        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        /// <summary>
        /// Increases the amount of this currency given by the customer.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void IncreaseCustomerAmount(object sender, RoutedEventArgs e)
        {
            CustomerAmount++;
        }

        /// <summary>
        /// Decreases the amount of this currency given by the customer.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event arguments.</param>
        private void DecreaseCustomerAmount(object sender, RoutedEventArgs e)
        {
            CustomerAmount--;
        }

        /// <summary>
        /// Ensures that the amount of currency from the customer stays in bounds (no 
        /// negative numbers).
        /// </summary>
        /// <param name="sender">The currency control.</param>
        /// <param name="e">The event arguments</param>
        static void HandleCustomerAmountChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(sender is CurrencyControl currencyControl)
            {
                if (currencyControl.CustomerAmount <= 0)
                {
                    currencyControl.CustomerAmount = 0;
                    currencyControl.decreaseButton.IsEnabled = false;
                }
                else currencyControl.decreaseButton.IsEnabled = true;
            }
        }
    }
}
