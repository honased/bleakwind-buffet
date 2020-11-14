/*
 * Author: Eric Honas
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Thalmor Triple entree.
    /// </summary>
    public class ThalmorTriple : Entree
    {
        private bool bun        = true;
        private bool ketchup    = true;
        private bool mustard    = true;
        private bool pickle     = true;
        private bool cheese     = true;
        private bool tomato     = true;
        private bool lettuce    = true;
        private bool mayo       = true;
        private bool bacon      = true;
        private bool egg        = true;

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
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether bacon should be added.
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bool invoke = bacon != value;
                bacon = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Whether the egg should be added.
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                bool invoke = egg != value;
                egg = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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
                return 8.32;
            }
        }

        /// <summary>
        /// The calories of the entre.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 943;
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

                if (!Bacon)
                {
                    instructions.Add("Hold bacon");
                }

                if (!Egg)
                {
                    instructions.Add("Hold egg");
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
            return "Thalmor Triple";
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        public override string Description => "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
    }
}
