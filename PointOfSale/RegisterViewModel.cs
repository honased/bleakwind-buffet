/*
 * Author: Eric Honas
 * Class name: RegisterViewModel.cs
 * Purpose: A ViewModel class used for providing access to the RoundRegister.CashDrawer.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// A class that acts as a ViewModel by providing access to the CashDrawer.
    /// </summary>
    public class RegisterViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// An event that triggers when a property has been changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The amount of pennies in the cash drawer.
        /// </summary>
        public int PenniesInDrawer
        {
            get => CashDrawer.Pennies;
            set => CashDrawer.Pennies = value;
        }

        /// <summary>
        /// The amount of pennies from the customer.
        /// </summary>
        public int PenniesFromCustomer { get; set; }

        /// <summary>
        /// The amount of pennies to give to the customer
        /// </summary>
        public int PenniesAsChange { get; set; }

        /// <summary>
        /// The amount of nickels in the cash drawer.
        /// </summary>
        public int NickelsInDrawer
        {
            get => CashDrawer.Nickels;
            set => CashDrawer.Nickels = value;
        }

        /// <summary>
        /// The amount of nickels from the customer.
        /// </summary>
        public int NickelsFromCustomer { get; set; }

        /// <summary>
        /// The amount of nickels to give to the customer
        /// </summary>
        public int NickelsAsChange { get; set; }

        /// <summary>
        /// The amount of dimes in the cash drawer.
        /// </summary>
        public int DimesInDrawer
        {
            get => CashDrawer.Dimes;
            set => CashDrawer.Dimes = value;
        }

        /// <summary>
        /// The amount of dimes from the customer.
        /// </summary>
        public int DimesFromCustomer { get; set; }

        /// <summary>
        /// The amount of dimes to give to the customer
        /// </summary>
        public int DimesAsChange { get; set; }

        /// <summary>
        /// The amount of quarters in the cash drawer.
        /// </summary>
        public int QuartersInDrawer
        {
            get => CashDrawer.Quarters;
            set => CashDrawer.Quarters = value;
        }

        /// <summary>
        /// The amount of quarters from the customer.
        /// </summary>
        public int QuartersFromCustomer { get; set; }

        /// <summary>
        /// The amount of quarters to give to the customer
        /// </summary>
        public int QuartersAsChange { get; set; }

        /// <summary>
        /// The amount of Half Dollars in the cash drawer.
        /// </summary>
        public int HalfDollarsInDrawer
        {
            get => CashDrawer.HalfDollars;
            set => CashDrawer.HalfDollars = value;
        }

        /// <summary>
        /// The amount of half dollars from the customer.
        /// </summary>
        public int HalfDollarsFromCustomer { get; set; }

        /// <summary>
        /// The amount of half dollars to give to the customer
        /// </summary>
        public int HalfDollarsAsChange { get; set; }

        /// <summary>
        /// The amount of Dollars in the cash drawer.
        /// </summary>
        public int DollarsInDrawer
        {
            get => CashDrawer.Dollars;
            set => CashDrawer.Dollars = value;
        }

        /// <summary>
        /// The amount of dollars from the customer.
        /// </summary>
        public int DollarsFromCustomer { get; set; }

        /// <summary>
        /// The amount of dollars to give to the customer
        /// </summary>
        public int DollarsAsChange { get; set; }

        /// <summary>
        /// The amount of ones in the cash drawer.
        /// </summary>
        public int OnesInDrawer
        {
            get => CashDrawer.Ones;
            set => CashDrawer.Ones = value;
        }

        /// <summary>
        /// The amount of ones from the customer.
        /// </summary>
        public int OnesFromCustomer { get; set; }

        /// <summary>
        /// The amount of ones to give to the customer
        /// </summary>
        public int OnesAsChange { get; set; }

        /// <summary>
        /// The amount of twos in the cash drawer.
        /// </summary>
        public int TwosInDrawer
        {
            get => CashDrawer.Twos;
            set => CashDrawer.Twos = value;
        }

        /// <summary>
        /// The amount of twos from the customer.
        /// </summary>
        public int TwosFromCustomer { get; set; }

        /// <summary>
        /// The amount of twos to give to the customer
        /// </summary>
        public int TwosAsChange { get; set; }

        /// <summary>
        /// The amount of fives in the cash drawer.
        /// </summary>
        public int FivesInDrawer
        {
            get => CashDrawer.Fives;
            set => CashDrawer.Fives = value;
        }

        /// <summary>
        /// The amount of fives from the customer.
        /// </summary>
        public int FivesFromCustomer { get; set; }

        /// <summary>
        /// The amount of fives to give to the customer
        /// </summary>
        public int FivesAsChange { get; set; }

        /// <summary>
        /// The amount of tens in the cash drawer.
        /// </summary>
        public int TensInDrawer
        {
            get => CashDrawer.Tens;
            set => CashDrawer.Tens = value;
        }

        /// <summary>
        /// The amount of tens from the customer.
        /// </summary>
        public int TensFromCustomer { get; set; }

        /// <summary>
        /// The amount of tens to give to the customer
        /// </summary>
        public int TensAsChange { get; set; }

        /// <summary>
        /// The amount of twenties in the cash drawer.
        /// </summary>
        public int TwentiesInDrawer
        {
            get => CashDrawer.Twenties;
            set => CashDrawer.Twenties = value;
        }

        /// <summary>
        /// The amount of twenties from the customer.
        /// </summary>
        public int TwentiesFromCustomer { get; set; }

        /// <summary>
        /// The amount of twenties to give to the customer
        /// </summary>
        public int TwentiesAsChange { get; set; }

        /// <summary>
        /// The amount of fifties in the cash drawer.
        /// </summary>
        public int FiftiesInDrawer
        {
            get => CashDrawer.Fifties;
            set => CashDrawer.Fifties = value;
        }

        /// <summary>
        /// The amount of fifties from the customer.
        /// </summary>
        public int FiftiesFromCustomer { get; set; }

        /// <summary>
        /// The amount of fifties to give to the customer
        /// </summary>
        public int FiftiesAsChange { get; set; }

        /// <summary>
        /// The amount of hundreds in the cash drawer.
        /// </summary>
        public int HundredsInDrawer
        {
            get => CashDrawer.Hundreds;
            set => CashDrawer.Hundreds = value;
        }

        /// <summary>
        /// The amount of hundreds from the customer.
        /// </summary>
        public int HundredsFromCustomer { get; set; }

        /// <summary>
        /// The amount of hundreds to give to the customer
        /// </summary>
        public int HundredsAsChange { get; set; }

        private double amountDue = 0;
        private double changeOwed = 0;

        private bool validSale = false;

        /// <summary>
        /// If the sale is valid or not based on if the customer has provided enough cash and if enough
        /// change can be given.
        /// </summary>
        public bool ValidSale
        {
            get => validSale;
            set
            {
                if(validSale != value)
                {
                    validSale = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ValidSale"));
                }
            }
        }

        /// <summary>
        /// The total amount still owed by the customer.
        /// </summary>
        public double AmountDue
        {
            get => amountDue;
            set
            {
                if(value != amountDue)
                {
                    amountDue = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
            }
        }

        /// <summary>
        /// The change owed to the customer.
        /// </summary>
        public double ChangeOwed
        {
            get => changeOwed;
            set
            {
                if (value != changeOwed)
                {
                    changeOwed = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                }
            }
        }

        /// <summary>
        /// The total amount of money in the drawer in US Dollars.
        /// </summary>
        /// <returns>The amount of money in the drawer.</returns>
        public double TotalAmountInDrawer()
        {
            return (PenniesInDrawer * 0.01) + (NickelsInDrawer * 0.05) + (DimesInDrawer * 0.1) +
                    (QuartersInDrawer * 0.25) + (HalfDollarsInDrawer * 0.5) + (DollarsInDrawer * 1) + 
                    (OnesInDrawer * 1) + (TwosInDrawer * 2) + (FivesInDrawer * 5) + (TensInDrawer * 10) +
                    (TwentiesInDrawer * 20) + (FiftiesInDrawer * 50) + (HundredsInDrawer * 100);
        }

        /// <summary>
        /// The amount of money from the customer in US dollars.
        /// </summary>
        /// <returns>The amount of money from the customer.</returns>
        public double TotalAmountFromCustomer()
        {
            return (PenniesFromCustomer * 0.01) + (NickelsFromCustomer * 0.05) + (DimesFromCustomer * 0.1) +
                    (QuartersFromCustomer * 0.25) + (HalfDollarsFromCustomer * 0.5) + (DollarsFromCustomer * 1) +
                    (OnesFromCustomer * 1) + (TwosFromCustomer * 2) + (FivesFromCustomer * 5) + (TensFromCustomer * 10) +
                    (TwentiesFromCustomer * 20) + (FiftiesFromCustomer * 50) + (HundredsFromCustomer * 100);
        }


        private bool canMakeChange;

        public bool CanMakeChange
        {
            get
            {
                return canMakeChange;
            }
            set
            {
                if(value != canMakeChange)
                {
                    canMakeChange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CanMakeChange"));
                }    
            }
        }

        /// <summary>
        /// Given the <paramref name="total"/> for the order, the appropriate change is
        /// made and it is determined if the sale is valid.
        /// </summary>
        /// <param name="total">The amount of money charged for the order.</param>
        public void MakeChange(double total)
        {
            total = Math.Round(total, 2);

            PenniesAsChange     = 0;
            NickelsAsChange     = 0;
            DimesAsChange       = 0;
            QuartersAsChange    = 0;
            HalfDollarsAsChange = 0;
            DollarsAsChange     = 0;
            OnesAsChange        = 0;
            TwosAsChange        = 0;
            FivesAsChange       = 0;
            TensAsChange        = 0;
            TwentiesAsChange    = 0;
            FiftiesAsChange     = 0;
            HundredsAsChange    = 0;

            AmountDue = Math.Round(total - TotalAmountFromCustomer(), 2);

            ChangeOwed = (AmountDue < 0) ? -AmountDue : 0;
            AmountDue = (AmountDue < 0) ? 0 : AmountDue;

            if (TotalAmountInDrawer() >= ChangeOwed && AmountDue == 0)
            {
                double amount = ChangeOwed;

                CanMakeChange = true;

                HundredsAsChange = Math.Min((int)(amount / 100), HundredsInDrawer);
                amount -= HundredsAsChange * 100;
                amount = Math.Round(amount, 2);

                FiftiesAsChange = Math.Min((int)(amount / 50), FiftiesInDrawer);
                amount -= FiftiesAsChange * 50;
                amount = Math.Round(amount, 2);

                TwentiesAsChange = Math.Min((int)(amount / 20), TwentiesInDrawer);
                amount -= TwentiesAsChange * 20;
                amount = Math.Round(amount, 2);

                TensAsChange = Math.Min((int)(amount / 10), TensInDrawer);
                amount -= TensAsChange * 10;
                amount = Math.Round(amount, 2);

                FivesAsChange = Math.Min((int)(amount / 5), FivesInDrawer);
                amount -= FivesAsChange * 5;
                amount = Math.Round(amount, 2);

                TwosAsChange = Math.Min((int)(amount / 2), TwosInDrawer);
                amount -= TwosAsChange * 2;
                amount = Math.Round(amount, 2);

                OnesAsChange = Math.Min((int)(amount / 1), OnesInDrawer);
                amount -= OnesAsChange * 1;
                amount = Math.Round(amount, 2);

                DollarsAsChange = Math.Min((int)(amount / 1), DollarsInDrawer);
                amount -= DollarsAsChange * 1;
                amount = Math.Round(amount, 2);

                HalfDollarsAsChange = Math.Min((int)(amount / 0.5), HalfDollarsAsChange);
                amount -= HalfDollarsAsChange * 0.5;
                amount = Math.Round(amount, 2);

                QuartersAsChange = Math.Min((int)(amount / 0.25), QuartersInDrawer);
                amount -= QuartersAsChange * 0.25;
                amount = Math.Round(amount, 2);

                DimesAsChange = Math.Min((int)(amount / 0.1), DimesInDrawer);
                amount -= DimesAsChange * 0.1;
                amount = Math.Round(amount, 2);

                NickelsAsChange = Math.Min((int)(amount / 0.05), NickelsInDrawer);
                amount -= NickelsAsChange * 0.05;
                amount = Math.Round(amount, 2);

                PenniesAsChange = Math.Min((int)(amount / 0.01), PenniesInDrawer);
                amount -= PenniesAsChange * 0.01;
                amount = Math.Round(amount, 2);

                ValidSale = true;
            }
            else
            {
                ValidSale = false;
                if(AmountDue == 0) CanMakeChange = false;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarsAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesAsChange"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsAsChange"));
        }

        /// <summary>
        /// If the sale is valid, the cash drawer is updated to take
        /// the customers cash while giving back any change.
        /// </summary>
        public void FinalizeOrder()
        {
            if (!ValidSale) return;

            CashDrawer.OpenDrawer();
            HundredsInDrawer        += HundredsFromCustomer     - HundredsAsChange;
            FiftiesInDrawer         += FiftiesFromCustomer      - FiftiesAsChange;
            TwentiesInDrawer        += TwentiesFromCustomer     - TwentiesAsChange;
            TensInDrawer            += TensFromCustomer         - TensAsChange;
            FivesInDrawer           += FivesFromCustomer        - FivesAsChange;
            TwosInDrawer            += TwosFromCustomer         - TwosAsChange;
            OnesInDrawer            += OnesFromCustomer         - OnesAsChange;
            DollarsInDrawer         += DollarsFromCustomer      - DollarsAsChange;
            HalfDollarsInDrawer     += HalfDollarsFromCustomer  - HalfDollarsAsChange;
            QuartersInDrawer        += QuartersFromCustomer     - QuartersAsChange;
            DimesInDrawer           += DimesFromCustomer        - DimesAsChange;
            NickelsInDrawer         += NickelsFromCustomer      - NickelsAsChange;
            PenniesInDrawer         += PenniesFromCustomer      - PenniesAsChange;
        }
    }
}
