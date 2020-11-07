using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using Website.Pages;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.WebsiteTests
{
    public class IndexModelTests
    {
        [Fact]
        public void IndexModelShouldBeAPageModel()
        {
            var model = new IndexModel(null);

            Assert.IsAssignableFrom<PageModel>(model);
        }

        [Fact]
        public void EntreesShouldReturnAllMenuEntrees()
        {
            var model = new IndexModel(null);
            model.MenuItems = Menu.FullMenu();
            List<Type> actual = new List<Type>();
            foreach(Entree e in Menu.Entrees())
            {
                actual.Add(e.GetType());
            }
            int index = 0;
            foreach(Entree e in model.Entrees)
            {
                Assert.Equal(actual[index++], e.GetType());
            }
        }

        [Fact]
        public void ShouldHaveAllDrinksWithDuplicateSailorSodaStrippedOut()
        {
            var model = new IndexModel(null);
            model.MenuItems = Menu.FullMenu();
            Assert.Collection<IOrderItem>(model.Drinks,
                item =>
                {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                },
                item =>
                {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                }
            );
        }

        [Fact]
        public void SidesShouldReturnAllMenuSides()
        {
            var model = new IndexModel(null);
            model.MenuItems = Menu.FullMenu();
            List<Type> actual = new List<Type>();
            foreach (Side s in Menu.Sides())
            {
                actual.Add(s.GetType());
            }
            int index = 0;
            foreach (Side s in model.Sides)
            {
                Assert.Equal(actual[index++], s.GetType());
            }
        }

        [Fact]
        public void SodaFlavorsShouldReturnAllFlavors()
        {
            var model = new IndexModel(null);
            Assert.Collection<string>(model.SodaFlavors,
                item =>
                {
                    Assert.Equal("Blackberry", item);
                },
                item =>
                {
                    Assert.Equal("Cherry", item);
                },
                item =>
                {
                    Assert.Equal("Grapefruit", item);
                },
                item =>
                {
                    Assert.Equal("Lemon", item);
                },
                item =>
                {
                    Assert.Equal("Peach", item);
                },
                item =>
                {
                    Assert.Equal("Watermelon", item);
                }
                );
        }
    }
}
