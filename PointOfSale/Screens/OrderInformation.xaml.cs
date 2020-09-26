/*
 * Author: Eric Honas
 * Class name: OrderInformation.xaml.cs
 * Purpose: A component used for displaying the current status of the order.
 */

using BleakwindBuffet.Data.Interfaces;
using System.Windows.Controls;

namespace PointOfSale.Screens
{
    /// <summary>
    /// A class that allows for users to see all items on the order and the total price of the order.
    /// </summary>
    public partial class OrderInformation : UserControl
    {
        /// <summary>
        /// Creates a new OrderInformation component.
        /// </summary>
        public OrderInformation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds the <paramref name="item"/> to the order.
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(IOrderItem item)
        {
            orderedItems.Items.Add(item);
        }
    }
}
