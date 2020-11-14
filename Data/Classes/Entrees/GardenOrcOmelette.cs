/*
 * Author: Eric Honas
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Garden Orc Omelette entree.
    /// </summary>
    public class GardenOrcOmelette : Entree
    {
        private bool broccoli       = true;
        private bool mushrooms      = true;
        private bool tomato         = true;
        private bool cheddar        = true;

        /// <summary>
        /// An event triggered when any property is changed.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Whether broccoli should be added.
        /// </summary>
        public bool Broccoli
        {
            get 
            {
                return broccoli;
            }
            set
            {
                bool invoke = broccoli != value;
                broccoli = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether mushrooms should be added.
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                bool invoke = mushrooms != value;
                mushrooms = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether tomato should be added.
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                bool invoke = tomato != value;
                tomato = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether cheddar should be added.
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                bool invoke = cheddar != value;
                cheddar = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// The price of the entree.
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// The calories of the entre.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 404;
            }
        }

        /// <summary>
        /// Special instructions for how to prepare the entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if(!Broccoli)
                {
                    instructions.Add("Hold broccoli");
                }

                if(!Mushrooms)
                {
                    instructions.Add("Hold mushrooms");
                }

                if(!Tomato)
                {
                    instructions.Add("Hold tomato");
                }

                if(!Cheddar)
                {
                    instructions.Add("Hold cheddar");
                }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the nicely formatted name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        public override string Description => "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
    }
}
