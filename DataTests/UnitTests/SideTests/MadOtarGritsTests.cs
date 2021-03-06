﻿/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
        }

        [Fact]
        public void ShouldBeAnOrderItem()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mog);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Equal(Size.Small, mog.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Size.Large;
            Assert.Equal(Size.Large, mog.Size);
            mog.Size = Size.Medium;
            Assert.Equal(Size.Medium, mog.Size);
            mog.Size = Size.Small;
            Assert.Equal(Size.Small, mog.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Empty(mog.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(price, mog.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(calories, mog.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(name, mog.ToString());
        }

        [Fact]
        public void WrongSizeShouldThrowException()
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = (Size)(int.MaxValue);
            Assert.Throws<System.NotImplementedException>(() => mog.Calories);
            Assert.Throws<System.NotImplementedException>(() => mog.Price);
            Assert.Throws<System.NotImplementedException>(() => mog.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var mog = new MadOtarGrits();
            Assert.PropertyChanged(mog, "Size", () =>
            {
                mog.Size = Size.Medium;
            });

            Assert.PropertyChanged(mog, "Size", () =>
            {
                mog.Size = Size.Large;
            });

            Assert.PropertyChanged(mog, "Size", () =>
            {
                mog.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new MadOtarGrits());
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var mog = new MadOtarGrits();
            Assert.Equal("Cheesey Grits.", mog.Description);
        }
    }
}