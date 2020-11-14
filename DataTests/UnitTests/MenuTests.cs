using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Classes;
using System.Linq;
using Xunit.Extensions;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldHaveAllEntrees()
        {
            Assert.Collection<IOrderItem>(Menu.Entrees(), 
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item)
                );
        }

        [Fact]
        public void ShouldHaveAllSides()
        {
            Assert.Collection<IOrderItem>(Menu.Sides(),
                item =>
                {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Small, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Medium, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Large, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Small, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Medium, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Large, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Small, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Medium, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Large, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Small, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Medium, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Large, (item as Side).Size);
                }
            );
        }

        [Fact]
        public void ShouldHaveAllDrinks()
        {
            Assert.Collection<IOrderItem>(Menu.Drinks(),
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
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
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
        public void ShouldHaveAllItemsOnFullMenu()
        {
            Assert.Collection<IOrderItem>(Menu.FullMenu(),
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<ThugsTBone>(item),
                item =>
                {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Small, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Medium, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Large, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Small, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Medium, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Large, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Small, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Medium, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Large, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Small, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Medium, (item as Side).Size);
                },
                item =>
                {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Large, (item as Side).Size);
                },
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
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
                },
                item =>
                {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, (item as Drink).Size);
                    Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
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
        public void SearchShouldReturnInputtedListIfSearchTermsIsNull()
        {
            List<Type> actual = new List<Type>();
            foreach(IOrderItem item in Menu.Search(Menu.FullMenu(), null))
            {
                actual.Add(item.GetType());
            }
            int index = 0;
            foreach (IOrderItem i in Menu.FullMenu())
            {
                Assert.Equal(actual[index++], i.GetType());
            }
        }

        [Fact]
        public void SearchShouldReturnNothingIfNullIsPassed()
        {
            Assert.Null(Menu.Search(null, null));
            Assert.Null(Menu.Search(null, "Test"));
        }

        [Theory]
        [InlineData("A")]
        [InlineData("ba")]
        [InlineData("nn")]
        [InlineData("burger")]
        [InlineData("cake Bun")]
        public void SearchShouldFilterOutProperly(string filter)
        {
            foreach(IOrderItem i in Menu.Search(Menu.FullMenu(), filter))
            {
                bool contains = false;

                foreach(string word in filter.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if(i.Name.ToLower().Contains(word) || i.Description.ToLower().Contains(word))
                    {
                        contains = true;
                        break;
                    }
                }

                Assert.True(contains);
            }
        }

        [Fact]
        public void FilterCategoriesShouldReturnInputtedListIfCategoriesIsNullOrEmpty()
        {
            List<Type> actual = new List<Type>();
            foreach (IOrderItem item in Menu.FilterByCategory(Menu.FullMenu(), null))
            {
                actual.Add(item.GetType());
            }
            int index = 0;
            foreach (IOrderItem i in Menu.FullMenu())
            {
                Assert.Equal(actual[index++], i.GetType());
            }

            actual = new List<Type>();
            foreach (IOrderItem item in Menu.FilterByCategory(Menu.FullMenu(), new List<string>()))
            {
                actual.Add(item.GetType());
            }
            index = 0;
            foreach (IOrderItem i in Menu.FullMenu())
            {
                Assert.Equal(actual[index++], i.GetType());
            }
        }

        [Fact]
        public void CategoryFilterShouldReturnNothingIfNullIsPassed()
        {
            Assert.Null(Menu.FilterByCategory(null, null));
            Assert.Null(Menu.FilterByCategory(null, new List<string>() { "hello", "World" }));
        }

        [Theory]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        [InlineData(false, false, true)]
        [InlineData(true, true, false)]
        [InlineData(false, true, true)]
        public void CategoryShouldFilterOutProperly(bool e, bool d, bool s)
        {
            List<string> categories = new List<string>();
            if (e) categories.Add("Entree");
            if (d) categories.Add("Drink");
            if (s) categories.Add("Side");
            foreach (IOrderItem i in Menu.FilterByCategory(Menu.FullMenu(), categories))
            {
                if (i is Entree) Assert.True(e);
                if (i is Drink) Assert.True(d);
                if (i is Side) Assert.True(s);
            }
        }

        [Fact]
        public void CaloriesFilterShouldReturnInputtedListIfMinAndMaxIsNull()
        {
            List<Type> actual = new List<Type>();
            foreach (IOrderItem item in Menu.FilterByCalories(Menu.FullMenu(), null, null))
            {
                actual.Add(item.GetType());
            }
            int index = 0;
            foreach (IOrderItem i in Menu.FullMenu())
            {
                Assert.Equal(actual[index++], i.GetType());
            }
        }

        [Theory]
        [InlineData(100)]
        [InlineData(275)]
        [InlineData(10)]
        public void CaloriesFilterShouldOnlyFilterByMinIfMaxIsNull(int min)
        {
            foreach (IOrderItem item in Menu.FilterByCalories(Menu.FullMenu(), min, null))
            {
                Assert.True(item.Calories >= min);
            }
        }

        [Theory]
        [InlineData(500)]
        [InlineData(275)]
        [InlineData(10)]
        public void CaloriesFilterShouldOnlyFilterByMaxIfMinIsNull(int max)
        {
            foreach (IOrderItem item in Menu.FilterByCalories(Menu.FullMenu(), null, max))
            {
                Assert.True(item.Calories <= max);
            }
        }

        [Theory]
        [InlineData(100, 500)]
        [InlineData(0, 999)]
        [InlineData(270, 320)]
        public void CaloriesFilterShouldOnlyFilterByBothMaxAndMinIfBothValid(int min, int max)
        {
            foreach (IOrderItem item in Menu.FilterByCalories(Menu.FullMenu(), min, max))
            {
                Assert.True(item.Calories <= max);
                Assert.True(item.Calories >= min);
            }
        }

        [Fact]
        public void PriceFilterShouldReturnInputtedListIfMinAndMaxIsNull()
        {
            List<Type> actual = new List<Type>();
            foreach (IOrderItem item in Menu.FilterByPrice(Menu.FullMenu(), null, null))
            {
                actual.Add(item.GetType());
            }
            int index = 0;
            foreach (IOrderItem i in Menu.FullMenu())
            {
                Assert.Equal(actual[index++], i.GetType());
            }
        }

        [Theory]
        [InlineData(0.58)]
        [InlineData(5.4)]
        [InlineData(20.0)]
        public void PriceFilterShouldOnlyFilterByMinIfMaxIsNull(double min)
        {
            foreach (IOrderItem item in Menu.FilterByPrice(Menu.FullMenu(), min, null))
            {
                Assert.True(item.Price >= min);
            }
        }

        [Theory]
        [InlineData(9.4)]
        [InlineData(2.84)]
        [InlineData(1.04)]
        public void PriceFilterShouldOnlyFilterByMaxIfMinIsNull(double max)
        {
            foreach (IOrderItem item in Menu.FilterByPrice(Menu.FullMenu(), null, max))
            {
                Assert.True(item.Price <= max);
            }
        }

        [Theory]
        [InlineData(0.5, 9.23)]
        [InlineData(1.27, 4.88)]
        [InlineData(6.7, 9.8)]
        public void PriceFilterShouldOnlyFilterByBothMaxAndMinIfBothValid(double min, double max)
        {
            foreach (IOrderItem item in Menu.FilterByPrice(Menu.FullMenu(), min, max))
            {
                Assert.True(item.Price <= max);
                Assert.True(item.Price >= min);
            }
        }

    }
}
