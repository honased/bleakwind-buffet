/*
 * Author: Eric Honas
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Smokehouse Skeleton entree.
    /// </summary>
    public class SmokehouseSkeleton
    {
        private bool sausageLink    = true;
        private bool egg            = true;
        private bool hashBrowns     = true;
        private bool pancake        = true;

        /// <summary>
        /// Gets and sets if sausage Links should be added.
        /// </summary>
        public bool SausageLink
        {
            get 
            {
                return sausageLink;
            }
            set
            {
                sausageLink = value;
            }
        }

        /// <summary>
        /// Gets and sets if the egg should be added.
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
            }
        }

        /// <summary>
        /// Gets and sets if hash browns should be added.
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                hashBrowns = value;
            }
        }

        /// <summary>
        /// Gets and sets if pancakes should be added.
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
            }
        }

        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public double Price
        {
            get
            {
                return 5.62;
            }
        }

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 602;
            }
        }

        /// <summary>
        /// Gets the list of special instructions.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if(!SausageLink)
                {
                    instructions.Add("Hold sausage");
                }

                if(!Egg)
                {
                    instructions.Add("Hold eggs");
                }

                if(!HashBrowns)
                {
                    instructions.Add("Hold hash browns");
                }

                if(!Pancake)
                {
                    instructions.Add("Hold pancakes");
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
            return "Smokehouse Skeleton";
        }
    }
}
