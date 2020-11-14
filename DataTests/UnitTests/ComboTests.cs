using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        private class DummyEntree : Entree
        {
            public override double Price => 3.14;

            public override uint Calories => 244;

            public override List<string> SpecialInstructions
            {
                get
                {
                    List<string> instructions = new List<string>();
                    if(!bun)
                    {
                        instructions.Add("Hold bun");
                    }

                    return instructions;
                }
            }

            public override string ToString()
            {
                return "Dummy Entree";
            }

            public override event PropertyChangedEventHandler PropertyChanged;

            private bool bun = true;

            public bool Bun
            {
                get
                {
                    return bun;
                }
                set
                {
                    bool invoke = bun != value;
                    bun = value;
                    if (invoke)
                    {
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    }
                }
            }

            public override string Description => "An entree used for testing.";
        }

        private class DummyDrink : Drink
        {
            public override Size Size
            {
                get
                {
                    return size;
                }
                set
                {
                    bool invoke = size != value;
                    size = value;
                    if (invoke)
                    {
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }

            private bool ice = true;
            public bool Ice
            {
                get
                {
                    return ice;
                }
                set
                {
                    bool invoke = ice != value;
                    ice = value;
                    if (invoke)
                    {
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    }
                }
            }

            public override double Price => 3.45;

            public override uint Calories => 192;

            public override List<string> SpecialInstructions
            {
                get
                {
                    List<string> instructions = new List<string>();
                    if (!ice)
                    {
                        instructions.Add("Hold ice");
                    }

                    return instructions;
                }
            }

            public override event PropertyChangedEventHandler PropertyChanged;

            public override string ToString()
            {
                return $"{Size} Dummy Drink";
            }

            public override string Description => "A drink used for testing.";
        }

        private class DummySide : Side
        {
            public override Size Size
            {
                get
                {
                    return size;
                }
                set
                {
                    bool invoke = size != value;
                    size = value;
                    if (invoke)
                    {
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }

            public override double Price => 4.21;

            public override uint Calories => 45;

            public override List<string> SpecialInstructions
            {
                get
                {
                    return new List<string>();
                }
            }

            public override event PropertyChangedEventHandler PropertyChanged;

            public override string ToString()
            {
                return $"{Size} Dummy Side";
            }

            public override string Description => "A side used for testing.";
        }

        [Fact]
        public void EntreeDrinkAndSideShouldBeSetByDefault()
        {
            var combo = new Combo();

            Assert.NotNull(combo.Entree);
            Assert.NotNull(combo.Drink);
            Assert.NotNull(combo.Side);
        }

        [Fact]
        public void ShouldNotBeAbleToSetDrinkEntreeOrSideToNull()
        {
            var combo = new Combo();

            combo.Side = null;
            combo.Entree = null;
            combo.Drink = null;

            Assert.NotNull(combo.Entree);
            Assert.NotNull(combo.Drink);
            Assert.NotNull(combo.Side);
        }

        [Fact]
        public void ShouldBeAbleToChangeEntree()
        {
            var combo = new Combo();

            var entree = new DummyEntree();

            combo.Entree = entree;

            Assert.Equal(entree, combo.Entree);
        }

        [Fact]
        public void ShouldBeAbleToChangeDrink()
        {
            var combo = new Combo();

            var drink = new DummyDrink();

            combo.Drink = drink;

            Assert.Equal(drink, combo.Drink);
        }

        [Fact]
        public void ShouldBeAbleToChangeSide()
        {
            var combo = new Combo();

            var side = new DummySide();

            combo.Side = side;

            Assert.Equal(side, combo.Side);
        }

        [Fact]
        public void ChangingEntreeNotifiesProperties()
        {
            var combo = new Combo();

            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = new DummyEntree();
            });

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = new DummyEntree();
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = new DummyEntree();
            });

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = new DummyEntree();
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesProperties()
        {
            var combo = new Combo();

            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = new DummyDrink();
            });

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = new DummyDrink();
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = new DummyDrink();
            });

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = new DummyDrink();
            });
        }

        [Fact]
        public void ChangingSideNotifiesProperties()
        {
            var combo = new Combo();

            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = new DummySide();
            });

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = new DummySide();
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = new DummySide();
            });

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = new DummySide();
            });
        }

        [Fact]
        public void CalculatesCorrectPrice()
        {
            var combo = new Combo();

            combo.Entree = new DummyEntree();
            combo.Drink = new DummyDrink();
            combo.Side = new DummySide();

            Assert.Equal(3.14 + 4.21 + 3.45 - 1, combo.Price);
        }

        [Fact]
        public void CalculatesCorrectCalories()
        {
            var combo = new Combo();

            combo.Entree = new DummyEntree();
            combo.Drink = new DummyDrink();
            combo.Side = new DummySide();

            Assert.Equal((uint)(45 + 192 + 244), combo.Calories);
        }

        [Fact]
        public void ChangingEntreePropertiesNotifiesProperties()
        {
            var combo = new Combo();
            var entree = new DummyEntree();
            combo.Entree = entree;

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                entree.Bun = false;
            });
        }

        [Fact]
        public void ChangingDrinkPropertiesNotifiesProperties()
        {
            var combo = new Combo();
            var drink = new DummyDrink();
            combo.Drink = drink;

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                drink.Ice = false;
            });

            Assert.PropertyChanged(combo, "Price", () =>
            {
                drink.Size = Size.Large;
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                drink.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSidePropertiesNotifiesProperties()
        {
            var combo = new Combo();
            var side = new DummySide();
            combo.Side = side;

            Assert.PropertyChanged(combo, "Price", () =>
            {
                side.Size = Size.Large;
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                side.Size = Size.Medium;
            });
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var combo = new Combo();
            Assert.Equal("Combo Deal", combo.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var combo = new Combo();
            var entree = new DummyEntree();
            var drink = new DummyDrink();
            var side = new DummySide();

            entree.Bun = false;

            drink.Size = Size.Medium;

            combo.Entree = entree;
            combo.Drink = drink;
            combo.Side = side;

            List<string> instructions = combo.SpecialInstructions;

            Assert.Collection(instructions,
                item => { Assert.Equal("Dummy Entree", item); },
                item => { Assert.Equal(" - Hold bun", item); },
                item => { Assert.Equal("Medium Dummy Drink", item); },
                item => { Assert.Equal("Small Dummy Side", item); }
            );
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItem()
        {
            var combo = new Combo();

            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var combo = new Combo();
            Assert.Equal("A combo that includes an entree, drink, and a side for 1$ off.", combo.Description);
        }
    }
}
