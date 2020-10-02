/*
 * Author: Eric Honas
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Double Draugr entree.
    /// </summary>
    public class DoubleDraugr : Entree
    {
        private bool bun        = true;
        private bool ketchup    = true;
        private bool mustard    = true;
        private bool pickle     = true;
        private bool cheese     = true;
        private bool tomato     = true;
        private bool lettuce    = true;
        private bool mayo       = true;

        /// <summary>
        /// An event triggered when any property is changed.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

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
                bool invoke = bun != value;
                bun = value;
                if (invoke) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
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
                bool invoke = ketchup != value;
                ketchup = value;
                if (invoke) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
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
                bool invoke = mustard != value;
                mustard = value;
                if (invoke) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
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
                bool invoke = pickle != value;
                pickle = value;
                if (invoke) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
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
                bool invoke = cheese != value;
                cheese = value;
                if (invoke) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
                if (invoke) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// Whether lettuce should be added.
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                bool invoke = lettuce != value;
                lettuce = value;
                if (invoke) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }

        /// <summary>
        /// Whether mayo should be added.
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                bool invoke = mayo != value;
                mayo = value;
                if (invoke) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <summary>
        /// The price of the entree.
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.32;
            }
        }

        /// <summary>
        /// The calories of the entre.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 843;
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

                if (!Tomato)
                {
                    instructions.Add("Hold tomato");
                }

                if (!Lettuce)
                {
                    instructions.Add("Hold lettuce");
                }

                if (!Mayo)
                {
                    instructions.Add("Hold mayo");
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
            return "Double Draugr";
        }
    }
}
