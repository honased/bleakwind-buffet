/*
 * Author: Eric Honas
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides a representation of the Markarth Milk drink.
    /// </summary>
    public class MarkarthMilk : Drink
    {
        private bool ice    = false;

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
        /// The price of the drink.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known.
        /// </exception>
        public override double Price
        {
            get
            {
                // Return the price baed on the size
                switch (Size)
                {
                    case Size.Small:
                        return 1.05;

                    case Size.Medium:
                        return 1.11;

                    case Size.Large:
                        return 1.22;

                    default:
                        throw new NotImplementedException($"Unknown size {Size}.");
                }
            }
        }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known.
        /// </exception>
        public override uint Calories
        {
            get
            {
                // Return the calories based on the size
                switch (Size)
                {
                    case Size.Small:
                        return 56;

                    case Size.Medium:
                        return 72;

                    case Size.Large:
                        return 93;

                    default:
                        throw new NotImplementedException($"Unknown size {Size}.");
                }
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
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the name for the size is not known.
        /// </exception>
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
                    throw new NotImplementedException($"Unknown size {Size}.");
            }

            return sizeString + " Markarth Milk";
        }
    }
}
