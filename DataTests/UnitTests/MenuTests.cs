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
    }
}
