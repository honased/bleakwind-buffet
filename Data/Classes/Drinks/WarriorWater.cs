﻿/*
 * Author: Eric Honas
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides a representation of the Warrior Water drink.
    /// </summary>
    public class WarriorWater
    {
        private bool ice    = true;
        private bool lemon  = false;
        private Size size = Size.Small;

        /// <summary>
        /// Whether ice should be added.
        /// </summary>
        public bool Ice
        {
            get 
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// Whether lemon should be added.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public double Price
        {
            get
            {
                return 0.00;
            }
        }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 0;
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

                if(!Ice)
                {
                    instructions.Add("Hold ice");
                }

                if(Lemon)
                {
                    instructions.Add("Add lemon");
                }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the nicely formatted name of the drink.
        /// </summary>
        /// <returns>The name of the drink as a string.</returns>
        public override string ToString()
        {
            string sizeString;

            // Determine what string to use based on the size.
            switch (Size)
            {
                case Size.Small:
                    sizeString = "Small";
                    break;

                case Size.Medium:
                    sizeString = "Medium";
                    break;

                case Size.Large:
                    sizeString = "Large";
                    break;

                default:
                    throw new Exception("Err: Can't create string with an invalid drink size.");
            }

            return sizeString + " Warrior Water";
        }
    }
}
