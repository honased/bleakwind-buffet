/*
 * Author: Eric Honas
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides a representation of the Sailor Soda drink.
    /// </summary>
    public class SailorSoda
    {
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;

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
        /// Gets and sets the flavor of the drink.
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known.
        /// </exception>
        public double Price
        {
            get
            {
                // Return the price baed on the size
                switch (Size)
                {
                    case Size.Small:
                        return 1.42;

                    case Size.Medium:
                        return 1.74;

                    case Size.Large:
                        return 2.07;

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
        public uint Calories
        {
            get
            {
                // Return the calories based on the size
                switch (Size)
                {
                    case Size.Small:
                        return 117;

                    case Size.Medium:
                        return 153;

                    case Size.Large:
                        return 205;

                    default:
                        throw new NotImplementedException($"Unknown size {Size}.");
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

                if(!Ice)
                {
                    instructions.Add("Hold ice");
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
            string sizeString, flavorString;

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

            // Determine what string to use based on the flavor.
            switch (Flavor)
            {
                case SodaFlavor.Blackberry:
                    flavorString = "Blackberry";
                    break;

                case SodaFlavor.Cherry:
                    flavorString = "Cherry";
                    break;

                case SodaFlavor.Grapefruit:
                    flavorString = "Grapefruit";
                    break;

                case SodaFlavor.Lemon:
                    flavorString = "Lemon";
                    break;

                case SodaFlavor.Peach:
                    flavorString = "Peach";
                    break;

                case SodaFlavor.Watermelon:
                    flavorString = "Watermelon";
                    break;

                default:
                    throw new Exception("Err: Can't create string with an invalid drink flavor.");
            }

            return sizeString + " " + flavorString + " Sailor Soda";
        }
    }
}
