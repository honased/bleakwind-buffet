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
    public class VokunSalad
    {
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of the side.
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
        /// Gets the price of the side.
        /// </summary>
        public double Price
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
                        throw new Exception("Err: Can't get the price of a side for a size that doesn't exist.");
                }
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        public uint Calories
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
                        throw new Exception("Err: Can't get the calories of a side for a size that doesn't exist.");
                }
            }
        }

        /// <summary>
        /// Gets the list of special instructions.
        /// </summary>
        public List<string> SpecialInstructions
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
                    throw new Exception("Err: Can't create string with an invalid side size.");
            }

            return sizeString + " Vokun Salad";
        }
    }
}
