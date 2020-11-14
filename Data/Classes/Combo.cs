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

        /// <summary>
        /// Creates a new combo that defaults to having a Briarheart Burger,
        /// Sailor Soda, and Dragonborn Waffle Fries.
        /// </summary>
        public Combo()
        {
            entree = new BriarheartBurger();
            drink = new SailorSoda();
            side = new DragonbornWaffleFries();

            entree.PropertyChanged += ItemChanged;
            drink.PropertyChanged += ItemChanged;
            side.PropertyChanged += ItemChanged;
        }

        /// <summary>
        /// The entree in the combo.
        /// </summary>
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

        /// <summary>
        /// The side in the combo.
        /// </summary>
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

        /// <summary>
        /// The drink in the combo.
        /// </summary>
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

        /// <summary>
        /// The total price of the combo with the discount.
        /// </summary>
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

        /// <summary>
        /// The amount of calories in the combo.
        /// </summary>
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

        /// <summary>
        /// Method that notifies the combo's specific properties based on the item in the combo 
        /// that was modified.
        /// </summary>
        /// <param name="sender">The item that was changed.</param>
        /// <param name="e">The event arguments.</param>
        private void ItemChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            if (e.PropertyName == "Calories") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            if (e.PropertyName == "SpecialInstructions" || e.PropertyName == "Name") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Special instructions forhow to prepare the combo.
        /// </summary>
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

        /// <summary>
        /// The name of the combo.
        /// </summary>
        public string Name => this.ToString();

        /// <summary>
        /// Returns the nicely formatted name of the combo.
        /// </summary>
        /// <returns>The name of the combo as a string.</returns>
        public override string ToString()
        {
            return "Combo Deal";
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        public string Description => "A combo that includes an entree, drink, and a side for 1$ off.";
    }
}
