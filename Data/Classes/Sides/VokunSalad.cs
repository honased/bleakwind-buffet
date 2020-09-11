/*
 * Author: Eric Honas
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides a representation of the Vokun Salad side.
    /// </summary>
    public class VokunSalad : Side
    {
        /// <summary>
        /// The price of the side.
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
                        return 0.93;

                    case Size.Medium:
                        return 1.28;

                    case Size.Large:
                        return 1.82;

                    default:
                        throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// The calories of the side.
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
                        return 41;

                    case Size.Medium:
                        return 52;

                    case Size.Large:
                        return 73;

                    default:
                        throw new NotImplementedException($"Unknown size {Size}");
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
                return new List<string>();
            }
        }

        /// <summary>
        /// Returns the nicely formatted name of the side.
        /// </summary>
        /// <returns>The name of the side as a string.</returns>
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

            return sizeString + " Vokun Salad";
        }
    }
}
