using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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
        public void DrinksShouldReturnAllMenuEntrees()
        {
            var model = new IndexModel(null);
            List<Type> actual = new List<Type>();
            foreach (Drink d in Menu.Drinks())
            {
                actual.Add(d.GetType());
            }
            int index = 0;
            foreach (Drink d in model.Drinks)
            {
                Assert.Equal(actual[index++], d.GetType());
            }
        }

        [Fact]
        public void SidesShouldReturnAllMenuEntrees()
        {
            var model = new IndexModel(null);
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
