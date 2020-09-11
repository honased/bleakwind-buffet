/*
 * Author: Eric Honas
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Briarheart Burger entree.
    /// </summary>
    public class BriarheartBurger : Entree
    {
        private bool bun        = true;
        private bool ketchup    = true;
        private bool mustard    = true;
        private bool pickle     = true;
        private bool cheese     = true;

        /// <summary>
        /// Whether the bun should be added.
        /// </summary>
        public bool Bun
        {
            get 
            {
                return bun;
            }
            set
            {
                bun = value;
            }
        }

        /// <summary>
        /// Whether ketchup should be added.
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
            }
        }

        /// <summary>
        /// Whether mustard should be added.
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
            }
        }

        /// <summary>
        /// Whether pickles should be added.
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
            }
        }

        /// <summary>
        /// Whether cheese should be added.
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
            }
        }

        /// <summary>
        /// The price of the entree.
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.32;
            }
        }

        /// <summary>
        /// The calories of the entre.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 743;
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

                if(!Bun)
                {
                    instructions.Add("Hold bun");
                }

                if(!Ketchup)
                {
                    instructions.Add("Hold ketchup");
                }

                if(!Mustard)
                {
                    instructions.Add("Hold mustard");
                }

                if(!Pickle)
                {
                    instructions.Add("Hold pickle");
                }

                if (!Cheese)
                {
                    instructions.Add("Hold cheese");
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
            return "Briarheart Burger";
        }
    }
}
