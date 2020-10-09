/*
 * Author: Eric Honas
 * Class name: Combo.cs
 * Purpose: Class used for representing a combo.
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Classes
{

    /// <summary>
    /// A class that represents a Combo by containing an entree, drink, and side.
    /// </summary>
    public class Combo : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Entree entree;
        private Drink drink;
        private Side side;

        public Combo()
        {
            entree = new BriarheartBurger();
            drink = new SailorSoda();
            side = new DragonbornWaffleFries();

            entree.PropertyChanged += ItemChanged;
            drink.PropertyChanged += ItemChanged;
            side.PropertyChanged += ItemChanged;
        }

        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if(entree != value && value != null)
                {
                    entree.PropertyChanged -= ItemChanged;

                    entree = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

                    entree.PropertyChanged += ItemChanged;
                }
            }
        }

        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != value && value != null)
                {
                    side.PropertyChanged -= ItemChanged;

                    side = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

                    side.PropertyChanged += ItemChanged;
                }
            }
        }

        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != value && value != null)
                {
                    drink.PropertyChanged -= ItemChanged;
                    drink = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

                    drink.PropertyChanged += ItemChanged;
                }
            }
        }

        public double Price
        {
            get
            {
                double price = 0.0;
                price += Entree.Price;
                price += Drink.Price;
                price += Side.Price;

                return price - 1.0;
            }
        }

        public uint Calories
        {
            get
            {
                uint calories = 0;
                calories += Entree.Calories;
                calories += Drink.Calories;
                calories += Side.Calories;

                return calories;
            }
        }

        private void ItemChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            if (e.PropertyName == "Calories") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            if (e.PropertyName == "SpecialInstructions" || e.PropertyName == "Name") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(Entree.Name);
                foreach(string instruction in entree.SpecialInstructions)
                {
                    instructions.Add(" - " + instruction);
                }


                instructions.Add(Drink.Name);
                foreach (string instruction in drink.SpecialInstructions)
                {
                    instructions.Add(" - " + instruction);
                }

                instructions.Add(Side.Name);
                foreach (string instruction in side.SpecialInstructions)
                {
                    instructions.Add(" - " + instruction);
                }

                return instructions;
            }
        }

        public string Name => this.ToString();

        public override string ToString()
        {
            return "Combo Deal";
        }
    }
}
