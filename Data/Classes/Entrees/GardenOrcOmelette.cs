/*
 * Author: Eric Honas
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Garden Orc Omelette entree.
    /// </summary>
    public class GardenOrcOmelette
    {
        private bool broccoli       = true;
        private bool mushrooms      = true;
        private bool tomato         = true;
        private bool cheddar        = true;

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
                broccoli = value;
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
                mushrooms = value;
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
                tomato = value;
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
                cheddar = value;
            }
        }

        /// <summary>
        /// The price of the entree.
        /// </summary>
        public double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// The calories of the entre.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 404;
            }
        }

        /// <summary>
        /// Special instructions for how to prepare the drink.
        /// </summary>
        public List<string> SpecialInstructions
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
    }
}
