using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PointOfSale;
using System.ComponentModel;
using RoundRegister;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class RegiesterViewModelTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var rvm = new RegisterViewModel();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(rvm);
        }

        [Fact]
        public void PenniesInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Pennies, rvm.PenniesInDrawer);

            rvm.PenniesInDrawer = 203;
            Assert.Equal(CashDrawer.Pennies, rvm.PenniesInDrawer);

            CashDrawer.Pennies = 92;
            Assert.Equal(CashDrawer.Pennies, rvm.PenniesInDrawer);
        }

        [Fact]
        public void PenniesShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.PenniesFromCustomer);
            Assert.Equal(0, rvm.PenniesAsChange);
        }

        [Fact]
        public void PenniesShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.PenniesFromCustomer = 10;
            Assert.Equal(10, rvm.PenniesFromCustomer);
            rvm.PenniesFromCustomer = 5;
            Assert.Equal(5, rvm.PenniesFromCustomer);

            rvm.PenniesAsChange = 10;
            Assert.Equal(10, rvm.PenniesAsChange);
            rvm.PenniesAsChange = 5;
            Assert.Equal(5, rvm.PenniesAsChange);
        }

        [Fact]
        public void NickelsInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Nickels, rvm.NickelsInDrawer);

            rvm.NickelsInDrawer = 203;
            Assert.Equal(CashDrawer.Nickels, rvm.NickelsInDrawer);

            CashDrawer.Nickels = 92;
            Assert.Equal(CashDrawer.Nickels, rvm.NickelsInDrawer);
        }

        [Fact]
        public void NickelsShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.NickelsFromCustomer);
            Assert.Equal(0, rvm.NickelsAsChange);
        }

        [Fact]
        public void NickelsShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.NickelsFromCustomer = 10;
            Assert.Equal(10, rvm.NickelsFromCustomer);
            rvm.NickelsFromCustomer = 5;
            Assert.Equal(5, rvm.NickelsFromCustomer);

            rvm.NickelsAsChange = 10;
            Assert.Equal(10, rvm.NickelsAsChange);
            rvm.NickelsAsChange = 5;
            Assert.Equal(5, rvm.NickelsAsChange);
        }

        [Fact]
        public void DimesInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Dimes, rvm.DimesInDrawer);

            rvm.DimesInDrawer = 203;
            Assert.Equal(CashDrawer.Dimes, rvm.DimesInDrawer);

            CashDrawer.Dimes = 92;
            Assert.Equal(CashDrawer.Dimes, rvm.DimesInDrawer);
        }

        [Fact]
        public void DimesShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.DimesFromCustomer);
            Assert.Equal(0, rvm.DimesAsChange);
        }

        [Fact]
        public void DimesShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.DimesFromCustomer = 10;
            Assert.Equal(10, rvm.DimesFromCustomer);
            rvm.DimesFromCustomer = 5;
            Assert.Equal(5, rvm.DimesFromCustomer);

            rvm.DimesAsChange = 10;
            Assert.Equal(10, rvm.DimesAsChange);
            rvm.DimesAsChange = 5;
            Assert.Equal(5, rvm.DimesAsChange);
        }

        [Fact]
        public void QuartersInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Quarters, rvm.QuartersInDrawer);

            rvm.QuartersInDrawer = 203;
            Assert.Equal(CashDrawer.Quarters, rvm.QuartersInDrawer);

            CashDrawer.Quarters = 92;
            Assert.Equal(CashDrawer.Quarters, rvm.QuartersInDrawer);
        }

        [Fact]
        public void QuartersShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.QuartersFromCustomer);
            Assert.Equal(0, rvm.QuartersAsChange);
        }

        [Fact]
        public void QuartersShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.QuartersFromCustomer = 10;
            Assert.Equal(10, rvm.QuartersFromCustomer);
            rvm.QuartersFromCustomer = 5;
            Assert.Equal(5, rvm.QuartersFromCustomer);

            rvm.QuartersAsChange = 10;
            Assert.Equal(10, rvm.QuartersAsChange);
            rvm.QuartersAsChange = 5;
            Assert.Equal(5, rvm.QuartersAsChange);
        }

        [Fact]
        public void HalfDollarsInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.HalfDollars, rvm.HalfDollarsInDrawer);

            rvm.HalfDollarsInDrawer = 203;
            Assert.Equal(CashDrawer.HalfDollars, rvm.HalfDollarsInDrawer);

            CashDrawer.HalfDollars = 92;
            Assert.Equal(CashDrawer.HalfDollars, rvm.HalfDollarsInDrawer);
        }

        [Fact]
        public void HalfDollarsShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.HalfDollarsFromCustomer);
            Assert.Equal(0, rvm.HalfDollarsAsChange);
        }

        [Fact]
        public void HalfDollarsShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.HalfDollarsFromCustomer = 10;
            Assert.Equal(10, rvm.HalfDollarsFromCustomer);
            rvm.HalfDollarsFromCustomer = 5;
            Assert.Equal(5, rvm.HalfDollarsFromCustomer);

            rvm.HalfDollarsAsChange = 10;
            Assert.Equal(10, rvm.HalfDollarsAsChange);
            rvm.HalfDollarsAsChange = 5;
            Assert.Equal(5, rvm.HalfDollarsAsChange);
        }

        [Fact]
        public void DollarsInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Dollars, rvm.DollarsInDrawer);

            rvm.DollarsInDrawer = 203;
            Assert.Equal(CashDrawer.Dollars, rvm.DollarsInDrawer);

            CashDrawer.Dollars = 92;
            Assert.Equal(CashDrawer.Dollars, rvm.DollarsInDrawer);
        }

        [Fact]
        public void DollarsShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.DollarsFromCustomer);
            Assert.Equal(0, rvm.DollarsAsChange);
        }

        [Fact]
        public void DollarsShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.DollarsFromCustomer = 10;
            Assert.Equal(10, rvm.DollarsFromCustomer);
            rvm.DollarsFromCustomer = 5;
            Assert.Equal(5, rvm.DollarsFromCustomer);

            rvm.DollarsAsChange = 10;
            Assert.Equal(10, rvm.DollarsAsChange);
            rvm.DollarsAsChange = 5;
            Assert.Equal(5, rvm.DollarsAsChange);
        }

        [Fact]
        public void OnesInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Ones, rvm.OnesInDrawer);

            rvm.OnesInDrawer = 203;
            Assert.Equal(CashDrawer.Ones, rvm.OnesInDrawer);

            CashDrawer.Ones = 92;
            Assert.Equal(CashDrawer.Ones, rvm.OnesInDrawer);
        }

        [Fact]
        public void OnesShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.OnesFromCustomer);
            Assert.Equal(0, rvm.OnesAsChange);
        }

        [Fact]
        public void OnesShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.OnesFromCustomer = 10;
            Assert.Equal(10, rvm.OnesFromCustomer);
            rvm.OnesFromCustomer = 5;
            Assert.Equal(5, rvm.OnesFromCustomer);

            rvm.OnesAsChange = 10;
            Assert.Equal(10, rvm.OnesAsChange);
            rvm.OnesAsChange = 5;
            Assert.Equal(5, rvm.OnesAsChange);
        }

        [Fact]
        public void TwosInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Twos, rvm.TwosInDrawer);

            rvm.TwosInDrawer = 203;
            Assert.Equal(CashDrawer.Twos, rvm.TwosInDrawer);

            CashDrawer.Twos = 92;
            Assert.Equal(CashDrawer.Twos, rvm.TwosInDrawer);
        }

        [Fact]
        public void TwosShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.TwosFromCustomer);
            Assert.Equal(0, rvm.TwosAsChange);
        }

        [Fact]
        public void TwosShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.TwosFromCustomer = 10;
            Assert.Equal(10, rvm.TwosFromCustomer);
            rvm.TwosFromCustomer = 5;
            Assert.Equal(5, rvm.TwosFromCustomer);

            rvm.TwosAsChange = 10;
            Assert.Equal(10, rvm.TwosAsChange);
            rvm.TwosAsChange = 5;
            Assert.Equal(5, rvm.TwosAsChange);
        }

        [Fact]
        public void FivesInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Fives, rvm.FivesInDrawer);

            rvm.FivesInDrawer = 203;
            Assert.Equal(CashDrawer.Fives, rvm.FivesInDrawer);

            CashDrawer.Fives = 92;
            Assert.Equal(CashDrawer.Fives, rvm.FivesInDrawer);
        }

        [Fact]
        public void FivesShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.FivesFromCustomer);
            Assert.Equal(0, rvm.FivesAsChange);
        }

        [Fact]
        public void FivesShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.FivesFromCustomer = 10;
            Assert.Equal(10, rvm.FivesFromCustomer);
            rvm.FivesFromCustomer = 5;
            Assert.Equal(5, rvm.FivesFromCustomer);

            rvm.FivesAsChange = 10;
            Assert.Equal(10, rvm.FivesAsChange);
            rvm.FivesAsChange = 5;
            Assert.Equal(5, rvm.FivesAsChange);
        }

        [Fact]
        public void TensInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Tens, rvm.TensInDrawer);

            rvm.TensInDrawer = 203;
            Assert.Equal(CashDrawer.Tens, rvm.TensInDrawer);

            CashDrawer.Tens = 92;
            Assert.Equal(CashDrawer.Tens, rvm.TensInDrawer);
        }

        [Fact]
        public void TensShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.TensFromCustomer);
            Assert.Equal(0, rvm.TensAsChange);
        }

        [Fact]
        public void TensShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.TensFromCustomer = 10;
            Assert.Equal(10, rvm.TensFromCustomer);
            rvm.TensFromCustomer = 5;
            Assert.Equal(5, rvm.TensFromCustomer);

            rvm.TensAsChange = 10;
            Assert.Equal(10, rvm.TensAsChange);
            rvm.TensAsChange = 5;
            Assert.Equal(5, rvm.TensAsChange);
        }

        [Fact]
        public void TwentiesInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Twenties, rvm.TwentiesInDrawer);

            rvm.TwentiesInDrawer = 203;
            Assert.Equal(CashDrawer.Twenties, rvm.TwentiesInDrawer);

            CashDrawer.Twenties = 92;
            Assert.Equal(CashDrawer.Twenties, rvm.TwentiesInDrawer);
        }

        [Fact]
        public void TwentiesShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.TwentiesFromCustomer);
            Assert.Equal(0, rvm.TwentiesAsChange);
        }

        [Fact]
        public void TwentiesShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.TwentiesFromCustomer = 10;
            Assert.Equal(10, rvm.TwentiesFromCustomer);
            rvm.TwentiesFromCustomer = 5;
            Assert.Equal(5, rvm.TwentiesFromCustomer);

            rvm.TwentiesAsChange = 10;
            Assert.Equal(10, rvm.TwentiesAsChange);
            rvm.TwentiesAsChange = 5;
            Assert.Equal(5, rvm.TwentiesAsChange);
        }

        [Fact]
        public void FiftiesInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Fifties, rvm.FiftiesInDrawer);

            rvm.FiftiesInDrawer = 203;
            Assert.Equal(CashDrawer.Fifties, rvm.FiftiesInDrawer);

            CashDrawer.Fifties = 92;
            Assert.Equal(CashDrawer.Fifties, rvm.FiftiesInDrawer);
        }

        [Fact]
        public void FiftiesShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.FiftiesFromCustomer);
            Assert.Equal(0, rvm.FiftiesAsChange);
        }

        [Fact]
        public void FiftiesShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.FiftiesFromCustomer = 10;
            Assert.Equal(10, rvm.FiftiesFromCustomer);
            rvm.FiftiesFromCustomer = 5;
            Assert.Equal(5, rvm.FiftiesFromCustomer);

            rvm.FiftiesAsChange = 10;
            Assert.Equal(10, rvm.FiftiesAsChange);
            rvm.FiftiesAsChange = 5;
            Assert.Equal(5, rvm.FiftiesAsChange);
        }

        [Fact]
        public void HundredsInDrawerShouldBeEqualToCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();
            Assert.Equal(CashDrawer.Hundreds, rvm.HundredsInDrawer);

            rvm.HundredsInDrawer = 203;
            Assert.Equal(CashDrawer.Hundreds, rvm.HundredsInDrawer);

            CashDrawer.Hundreds = 92;
            Assert.Equal(CashDrawer.Hundreds, rvm.HundredsInDrawer);
        }

        [Fact]
        public void HundredsShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.HundredsFromCustomer);
            Assert.Equal(0, rvm.HundredsAsChange);
        }

        [Fact]
        public void HundredsShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.HundredsFromCustomer = 10;
            Assert.Equal(10, rvm.HundredsFromCustomer);
            rvm.HundredsFromCustomer = 5;
            Assert.Equal(5, rvm.HundredsFromCustomer);

            rvm.HundredsAsChange = 10;
            Assert.Equal(10, rvm.HundredsAsChange);
            rvm.HundredsAsChange = 5;
            Assert.Equal(5, rvm.HundredsAsChange);
        }

        [Fact]
        public void ValidSaleShouldDefaultToFalse()
        {
            var rvm = new RegisterViewModel();
            Assert.False(rvm.ValidSale);
        }

        [Fact]
        public void ValidSaleShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.ValidSale = true;
            Assert.True(rvm.ValidSale);
            rvm.ValidSale = false;
            Assert.False(rvm.ValidSale);
        }

        [Fact]
        public void ChangingValidSaleShouldNotifyProperty()
        {
            var rvm = new RegisterViewModel();
            Assert.PropertyChanged(rvm, "ValidSale", () => rvm.ValidSale = true);
            Assert.PropertyChanged(rvm, "ValidSale", () => rvm.ValidSale = false);
        }

        [Fact]
        public void AmountDueShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.AmountDue);
        }

        [Fact]
        public void AmountDueShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.AmountDue = 100;
            Assert.Equal(100, rvm.AmountDue);
            rvm.AmountDue = 36;
            Assert.Equal(36, rvm.AmountDue);
        }

        [Fact]
        public void ChangingAmountDueShouldNotifyProperty()
        {
            var rvm = new RegisterViewModel();
            Assert.PropertyChanged(rvm, "AmountDue", () => rvm.AmountDue = 32);
            Assert.PropertyChanged(rvm, "AmountDue", () => rvm.AmountDue = 47);
        }

        [Fact]
        public void ChangeOwedShouldDefaultToZero()
        {
            var rvm = new RegisterViewModel();
            Assert.Equal(0, rvm.ChangeOwed);
        }

        [Fact]
        public void ChangeOwedShouldBeSettable()
        {
            var rvm = new RegisterViewModel();
            rvm.ChangeOwed = 100;
            Assert.Equal(100, rvm.ChangeOwed);
            rvm.ChangeOwed = 36;
            Assert.Equal(36, rvm.ChangeOwed);
        }

        [Fact]
        public void ChangingChangeOwedShouldNotifyProperty()
        {
            var rvm = new RegisterViewModel();
            Assert.PropertyChanged(rvm, "ChangeOwed", () => rvm.ChangeOwed = 32);
            Assert.PropertyChanged(rvm, "ChangeOwed", () => rvm.ChangeOwed = 47);
        }

        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData(5, 4, 90, 0, 20, 30, 44, 2, 0, 72, 0, 1, 0)]
        [InlineData(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)]
        public void TotalAmountInDrawerShouldEqualTotalAmount(int pen, int nick, int dimes, int quart, int hd, int dol, int ones, int twos, int fives, int tens, int twen, int fift, int hund)
        {
            CashDrawer.ResetDrawer();

            double total = (pen * 0.01) + (nick * 0.05) + (dimes * 0.1) + (quart * 0.25) + (hd * 0.5) + (dol * 1) + (ones * 1) + (twos * 2) + (fives * 5) + (tens * 10) + (twen * 20) + (fift * 50) + (hund * 100);
            total = Math.Round(total, 2);
            var rvm = new RegisterViewModel();
            rvm.PenniesInDrawer = pen;
            rvm.NickelsInDrawer = nick;
            rvm.DimesInDrawer = dimes;
            rvm.QuartersInDrawer = quart;
            rvm.HalfDollarsInDrawer = hd;
            rvm.DollarsInDrawer = dol;
            rvm.OnesInDrawer = ones;
            rvm.TwosInDrawer = twos;
            rvm.FivesInDrawer = fives;
            rvm.TensInDrawer = tens;
            rvm.TwentiesInDrawer = twen;
            rvm.FiftiesInDrawer = fift;
            rvm.HundredsInDrawer = hund;

            Assert.Equal(Math.Round(rvm.TotalAmountInDrawer(), 2), total);
        }

        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData(5, 4, 90, 0, 20, 30, 44, 2, 0, 72, 0, 1, 0)]
        [InlineData(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)]
        public void TotalAmountFromCustomerShouldEqualTotalAmount(int pen, int nick, int dimes, int quart, int hd, int dol, int ones, int twos, int fives, int tens, int twen, int fift, int hund)
        {
            CashDrawer.ResetDrawer();

            double total = (pen * 0.01) + (nick * 0.05) + (dimes * 0.1) + (quart * 0.25) + (hd * 0.5) + (dol * 1) + (ones * 1) + (twos * 2) + (fives * 5) + (tens * 10) + (twen * 20) + (fift * 50) + (hund * 100);
            total = Math.Round(total, 2);
            var rvm = new RegisterViewModel();
            rvm.PenniesFromCustomer = pen;
            rvm.NickelsFromCustomer = nick;
            rvm.DimesFromCustomer = dimes;
            rvm.QuartersFromCustomer = quart;
            rvm.HalfDollarsFromCustomer = hd;
            rvm.DollarsFromCustomer = dol;
            rvm.OnesFromCustomer = ones;
            rvm.TwosFromCustomer = twos;
            rvm.FivesFromCustomer = fives;
            rvm.TensFromCustomer = tens;
            rvm.TwentiesFromCustomer = twen;
            rvm.FiftiesFromCustomer = fift;
            rvm.HundredsFromCustomer = hund;

            Assert.Equal(Math.Round(rvm.TotalAmountFromCustomer(), 2), total);
        }

        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData(0, 3.75, 0, 0, 0, 3, 0, 0, 1, 1, 0, 0, 0, 0, 0)]
        [InlineData(1.53, 5.00, 3, 0, 5, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0)]
        public void MakeChangeShouldReturnCorrectChange(double change, double total, int pen, int nick, int dimes, int quart, int hd, int dol, int ones, int twos, int fives, int tens, int twen, int fift, int hund)
        {
            CashDrawer.ResetDrawer();

            var rvm = new RegisterViewModel();
            rvm.PenniesFromCustomer = pen;
            rvm.NickelsFromCustomer = nick;
            rvm.DimesFromCustomer = dimes;
            rvm.QuartersFromCustomer = quart;
            rvm.HalfDollarsFromCustomer = hd;
            rvm.DollarsFromCustomer = dol;
            rvm.OnesFromCustomer = ones;
            rvm.TwosFromCustomer = twos;
            rvm.FivesFromCustomer = fives;
            rvm.TensFromCustomer = tens;
            rvm.TwentiesFromCustomer = twen;
            rvm.FiftiesFromCustomer = fift;
            rvm.HundredsFromCustomer = hund;

            rvm.MakeChange(total);

            double actualChange = (rvm.PenniesAsChange * 0.01) + (rvm.NickelsAsChange * 0.05) + (rvm.DimesAsChange * 0.1) +
                    (rvm.QuartersAsChange * 0.25) + (rvm.HalfDollarsAsChange * 0.5) + (rvm.DollarsAsChange * 1) +
                    (rvm.OnesAsChange * 1) + (rvm.TwosAsChange * 2) + (rvm.FivesAsChange * 5) + (rvm.TensAsChange * 10) +
                    (rvm.TwentiesAsChange * 20) + (rvm.FiftiesAsChange * 50) + (rvm.HundredsAsChange * 100);

            Assert.Equal(change, actualChange);
        }

        [Fact]
        public void MakeChangeShouldUpdateAmountDue()
        {
            CashDrawer.ResetDrawer();

            var rvm = new RegisterViewModel();
            rvm.OnesFromCustomer = 1;

            rvm.MakeChange(1.73);
            Assert.Equal(0.73, rvm.AmountDue);

            rvm.OnesFromCustomer = 2;
            rvm.MakeChange(1.73);
            Assert.Equal(0, rvm.AmountDue);
        }

        [Fact]
        public void MakeChangeShouldUpdateChangeOwed()
        {
            CashDrawer.ResetDrawer();

            var rvm = new RegisterViewModel();
            rvm.OnesFromCustomer = 2;

            rvm.MakeChange(1.73);
            Assert.Equal(0.27, rvm.ChangeOwed);

            rvm.OnesFromCustomer = 1;
            rvm.MakeChange(1.73);
            Assert.Equal(0, rvm.ChangeOwed);
        }

        [Fact]
        public void MakeChangeShouldUpdateValidSale()
        {
            CashDrawer.ResetDrawer();

            var rvm = new RegisterViewModel();
            rvm.OnesFromCustomer = 2;

            Assert.False(rvm.ValidSale);

            // Ensure that there is always enough to make change
            rvm.PenniesInDrawer = 200;

            rvm.MakeChange(1.73);
            Assert.True(rvm.ValidSale);

            rvm.MakeChange(99999999);
            Assert.False(rvm.ValidSale);
        }

        [Fact]
        public void MakingChangeShouldNotifyProperties()
        {
            CashDrawer.ResetDrawer();

            var rvm = new RegisterViewModel();

            Assert.PropertyChanged(rvm, "PenniesAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "NickelsAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "DimesAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "QuartersAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "HalfDollarsAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "DollarsAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "OnesAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "TwosAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "FivesAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "TensAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "TwentiesAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "FiftiesAsChange", () => rvm.MakeChange(1.00));
            Assert.PropertyChanged(rvm, "HundredsAsChange", () => rvm.MakeChange(1.00));
        }

        [Fact]
        public void FinalizeOrderShouldUpdateCashDrawer()
        {
            CashDrawer.ResetDrawer();
            var rvm = new RegisterViewModel();

            rvm.PenniesInDrawer = 5;
            rvm.NickelsInDrawer = 4;
            rvm.DimesInDrawer = 10;
            rvm.QuartersInDrawer = 4;
            rvm.HalfDollarsInDrawer = 3;
            rvm.DollarsInDrawer = 0;
            rvm.OnesInDrawer = 3;
            rvm.TwosInDrawer = 1;
            rvm.FivesInDrawer = 0;
            rvm.TensInDrawer = 2;
            rvm.TwentiesInDrawer = 0;
            rvm.FiftiesInDrawer = 3;
            rvm.HundredsInDrawer = 1;

            rvm.OnesFromCustomer = 2;
            rvm.TwosFromCustomer = 2;

            rvm.MakeChange(5.52);

            rvm.FinalizeOrder();

            Assert.Equal(1, rvm.HundredsInDrawer);
            Assert.Equal(3, rvm.FiftiesInDrawer);
            Assert.Equal(0, rvm.TwentiesInDrawer);
            Assert.Equal(2, rvm.TensInDrawer);
            Assert.Equal(0, rvm.FivesInDrawer);
            Assert.Equal(3, rvm.TwosInDrawer);
            Assert.Equal(5, rvm.OnesInDrawer);
            Assert.Equal(0, rvm.DollarsInDrawer);
            Assert.Equal(3, rvm.HalfDollarsInDrawer);
            Assert.Equal(3, rvm.QuartersInDrawer);
            Assert.Equal(8, rvm.DimesInDrawer);
            Assert.Equal(4, rvm.NickelsInDrawer);
            Assert.Equal(2, rvm.PenniesInDrawer);
        }
    }
}
