/*
 * Author: Eric Honas
 * Class name: Entree.cs
 * Purpose: Class used for representing an order of items.
 */

using BleakwindBuffet.Data.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Classes
{
    /// <summary>
    /// A class that represents an Order by storing different IOrderItems.
    /// </summary>
    public class Order : ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// A collection of the items.
        /// </summary>
        private List<IOrderItem> _items;

        /// <summary>
        /// Creates a new order class.
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber += 1;
            _items = new List<IOrderItem>();
        }

        /// <summary>
        /// Cleans up the order class.
        /// </summary>
        ~Order()
        {
            foreach(IOrderItem item in _items)
            {
                item.PropertyChanged -= ItemChanged;
            }
        }

        /// <summary>
        /// The sales tax of the order.
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// The cost of all the items in the order without tax.
        /// </summary>
        public double Subtotal
        {
            get
            {
                double amount = 0.0;
                foreach(IOrderItem item in _items)
                {
                    amount += item.Price;
                }
                return amount;
            }
        }

        /// <summary>
        /// The tax of all the items in the order.
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }

        /// <summary>
        /// The cost of all items in the order with tax included.
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        /// <summary>
        /// The total calories of all the items in the order.
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach (IOrderItem item in _items)
                {
                    calories += item.Calories;
                }

                return calories;
            }
        }

        /// <summary>
        /// The next order number to be used.
        /// </summary>
        private static int nextOrderNumber = 1;

        /// <summary>
        /// An event that triggers when the collection of items has been changed.
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// An event that triggers when a property has been changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The order number specific to this order.
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// The number of items in the order.
        /// </summary>
        public int Count => _items.Count;

        /// <summary>
        /// If the collection is thread safe.
        /// </summary>
        public bool IsSynchronized => false;

        /// <summary>
        /// Required by the ICollection interface, but it is not implemented.
        /// </summary>
        /// <exception cref="System.NotImplementedException">Always thrown.</exception>
        public object SyncRoot => throw new NotImplementedException();

        /// <summary>
        /// Adds the <paramref name="item"/> to the order.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        public void Add(IOrderItem item)
        {
            _items.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));

            item.PropertyChanged += ItemChanged;
        }

        /// <summary>
        /// Removes the <paramref name="item"/> from the order.
        /// </summary>
        /// <param name="item">The item to be removed.</param>
        public void Remove(IOrderItem item)
        {
            int index = _items.IndexOf(item);
            if (_items.Remove(item))
            {
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));

                item.PropertyChanged -= ItemChanged;
            }
        }

        /// <summary>
        /// Required by the ICollection interface, but it is not implemented.
        /// </summary>
        /// <exception cref="System.NotImplementedException">Always thrown.</exception>
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// An enumerator of all items in the order.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            foreach(IOrderItem item in _items)
            {
                yield return item;
            }
        }

        /// <summary>
        /// If the order contains the given <paramref name="item"/>.
        /// </summary>
        /// <param name="item">The item to search for.</param>
        /// <returns></returns>
        public bool Contains(IOrderItem item)
        {
            return _items.Contains(item);
        }

        /// <summary>
        /// Invokes the propertychanged event if one of the items in the
        /// order modifies their price or calories.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }

            if(e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
