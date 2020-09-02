/*
 * Author: Eric Honas
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides a representation of the Aretino Apple Juice drink.
    /// </summary>
    public class AretinoAppleJuice
    {
        private bool ice    = false;
        private Size size   = Size.Small;

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
                // Return the price baed on the size
                switch (Size)
                {
                    case Size.Small:
                        return 0.62;

                    case Size.Medium:
                        return 0.87;

                    case Size.Large:
                        return 1.01;

                    default:
                        throw new Exception("Err: Can't get the price of a drink for a size that doesn't exist.");
                }
            }
        }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public uint Calories
        {
            get
            {
                // Return the calories based on the size
                switch (Size)
                {
                    case Size.Small:
                        return 44;

                    case Size.Medium:
                        return 88;

                    case Size.Large:
                        return 132;

                    default:
                        throw new Exception("Err: Can't get the calories of a drink for a size that doesn't exist.");
                }
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

                if(Ice)
                {
                    instructions.Add("Add ice");
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

            return sizeString + " Aretino Apple Juice";
        }
    }
}
