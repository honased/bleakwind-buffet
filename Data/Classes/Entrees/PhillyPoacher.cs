/*
 * Author: Eric Honas
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Philly Poacher entree.
    /// </summary>
    public class PhillyPoacher : Entree
    {
        private bool sirloin    = true;
        private bool onion      = true;
        private bool roll       = true;

        /// <summary>
        /// An event triggered when any property is changed.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Whether sirloin should be added.
        /// </summary>
        public bool Sirloin
        {
            get 
            {
                return sirloin;
            }
            set
            {
                bool invoke = sirloin != value;
                sirloin = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether onion should be added.
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                bool invoke = onion != value;
                onion = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the roll should be added.
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                bool invoke = roll != value;
                roll = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
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
                return 7.23;
            }
        }

        /// <summary>
        /// The calories of the entre.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// Special instructions for how to prepare the drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if(!Sirloin)
                {
                    instructions.Add("Hold sirloin");
                }

                if(!Onion)
                {
                    instructions.Add("Hold onions");
                }

                if(!Roll)
                {
                    instructions.Add("Hold roll");
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
            return "Philly Poacher";
        }
    }
}
