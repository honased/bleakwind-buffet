using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        private class MockupDrink : Drink
        {
            public override Size Size
            {
                get => size;
                set
                {
                    if (size != value)
                    {
                        size = value;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    }
                }
            }

            public override double Price => 1.39;

            public override uint Calories => 204;

            public override List<string> SpecialInstructions => new List<string>();

            public override event PropertyChangedEventHandler PropertyChanged;

            public void RaiseEvent(string property)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        [Fact]
        public void ShouldBeEmptyByDefault()
        {
            Order order = new Order();

            Assert.Empty(order);
        }

        [Fact]
        public void SalesTaxShouldBeTwelvePercent()
        {
            Order order = new Order();

            Assert.Equal(0.12, order.SalesTaxRate);
        }

        [Fact]
        public void IsSynchronizedIsTrueByDefault()
        {
            var order = new Order();

            Assert.True(order.IsSynchronized);
        }

        [Fact]
        public void SyncRootThrowsException()
        {
            var order = new Order();

            Assert.Throws<NotImplementedException>(() => order.SyncRoot);
        }

        [Fact]
        public void CopyToThrowsException()
        {
            var order = new Order();

            Assert.Throws<NotImplementedException>(() => order.CopyTo(new IOrderItem[10], 0));
        }

        [Fact]
        public void CreatingANewOrderShouldIncreaseOrderNumber()
        {
            Order order = new Order();
            int initialNumber = order.Number;

            for (int i = 1; i <= 100; i++)
            {
                order = new Order();
                Assert.Equal(initialNumber + i, order.Number);
            }
        }

        [Fact]
        public void ItemsCanBeAdded()
        {
            Order order = new Order();
            MockupDrink drink = new MockupDrink();

            Assert.False(order.Contains(drink));

            order.Add(drink);

            Assert.True(order.Contains(drink));
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void AddingItemsNotifiesProperties(string property)
        {
            Order order = new Order();

            Assert.PropertyChanged(order, property, () =>
            {
                order.Add(new MockupDrink());
            });
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void RemovingItemsNotifiesProperties(string property)
        {
            Order order = new Order();

            var drink = new MockupDrink();

            order.Add(drink);

            Assert.PropertyChanged(order, property, () =>
            {
                order.Remove(drink);
            });
        }

        [Fact]
        public void ItemPriceNotificationNotifiesProperties()
        {
            Order order = new Order();

            var drink = new MockupDrink();

            order.Add(drink);

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                drink.RaiseEvent("Price");
            });

            Assert.PropertyChanged(order, "Tax", () =>
            {
                drink.RaiseEvent("Price");
            });

            Assert.PropertyChanged(order, "Total", () =>
            {
                drink.RaiseEvent("Price");
            });
        }

        [Fact]
        public void ItemCaloriesNotificationNotifiesProperties()
        {
            Order order = new Order();

            var drink = new MockupDrink();

            order.Add(drink);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                drink.RaiseEvent("Calories");
            });
        }

        [Fact]
        public void OrderCalculatesCorrectSubtotal()
        {
            Order order = new Order();

            Assert.Equal(0, order.Subtotal);

            double expectedSubtotal = 0;

            var price = new MockupDrink().Price;

            List<IOrderItem> items = new List<IOrderItem>();

            for (int i = 0; i < 100; i++)
            {
                expectedSubtotal += price;
                var drink = new MockupDrink();
                items.Add(drink);
                order.Add(drink);
                Assert.Equal(Math.Round(expectedSubtotal, 2), Math.Round(order.Subtotal, 2));
            }

            for (int i = 0; i < 100; i++)
            {
                expectedSubtotal -= price;
                order.Remove(items[i]);
                Assert.Equal(Math.Round(expectedSubtotal, 2), Math.Round(order.Subtotal, 2));
            }
        }

        [Fact]
        public void OrderCalculatesCorrectCalories()
        {
            Order order = new Order();

            Assert.Equal(0, order.Subtotal);

            double expectedCalories = 0;

            var calories = new MockupDrink().Calories;

            List<IOrderItem> items = new List<IOrderItem>();

            for (int i = 0; i < 100; i++)
            {
                expectedCalories += calories;
                var drink = new MockupDrink();
                items.Add(drink);
                order.Add(drink);
                Assert.Equal(Math.Round(expectedCalories, 2), order.Calories);
            }

            for (int i = 0; i < 100; i++)
            {
                expectedCalories -= calories;
                order.Remove(items[i]);
                Assert.Equal(Math.Round(expectedCalories, 2), order.Calories);
            }
        }

        [Fact]
        public void OrderCalculatesCorrectTax()
        {
            Order order = new Order();

            Assert.Equal(0, order.Subtotal);

            double expectedSubtotal = 0;

            var price = new MockupDrink().Price;

            List<IOrderItem> items = new List<IOrderItem>();

            for (int i = 0; i < 100; i++)
            {
                expectedSubtotal += price;
                var drink = new MockupDrink();
                items.Add(drink);
                order.Add(drink);
                Assert.Equal(Math.Round(expectedSubtotal * 0.12, 2), Math.Round(order.Tax, 2));
            }

            for (int i = 0; i < 100; i++)
            {
                expectedSubtotal -= price;
                order.Remove(items[i]);
                Assert.Equal(Math.Round(expectedSubtotal * 0.12, 2), Math.Round(order.Tax, 2));
            }
        }

        [Fact]
        public void OrderCalculatesCorrectTotal()
        {
            Order order = new Order();

            Assert.Equal(0, order.Subtotal);

            double expectedSubtotal = 0;

            var price = new MockupDrink().Price;

            List<IOrderItem> items = new List<IOrderItem>();

            for (int i = 0; i < 100; i++)
            {
                expectedSubtotal += price;
                var drink = new MockupDrink();
                items.Add(drink);
                order.Add(drink);
                Assert.Equal(Math.Round(expectedSubtotal * 1.12, 2), Math.Round(order.Total, 2));
            }

            for (int i = 0; i < 100; i++)
            {
                expectedSubtotal -= price;
                order.Remove(items[i]);
                Assert.Equal(Math.Round(expectedSubtotal * 1.12, 2), Math.Round(order.Total, 2));
            }
        }

        [Fact]
        public void OrderHasCorrectCount()
        {
            Order order = new Order();

            var d1 = new MockupDrink();
            var d2 = new MockupDrink();

            Assert.Equal(0, order.Count);

            order.Add(d1);
            Assert.Equal(1, order.Count);

            order.Add(d2);
            Assert.Equal(2, order.Count);

            order.Remove(d1);
            Assert.Equal(1, order.Count);

            order.Remove(d2);
            Assert.Equal(0, order.Count);
        }

        [Fact]
        public void CanSetSalesTaxRate()
        {
            var order = new Order();

            order.SalesTaxRate = .15;

            Assert.Equal(.15, order.SalesTaxRate);

            order.SalesTaxRate = .49;

            Assert.Equal(.49, order.SalesTaxRate);
        }
    }
}
