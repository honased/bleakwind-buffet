/*
 * Author: Eric Honas
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides a representation of the Candlehearth Coffee drink.
    /// </summary>
    public class CandlehearthCoffee : Drink
    {
        private bool ice            = false;
        private bool decaf          = false;
        private bool roomForCream   = false;

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
        /// Whether the coffee should be decaf.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }

        /// <summary>
        /// Whether cream should be added.
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
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
                        return 0.75;

                    case Size.Medium:
                        return 1.25;

                    case Size.Large:
                        return 1.75;

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
                        return 7;

                    case Size.Medium:
                        return 10;

                    case Size.Large:
                        return 20;

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

                if(RoomForCream)
                {
                    instructions.Add("Add cream");
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

            return sizeString + (Decaf ? " Decaf Candlehearth Coffee" : " Candlehearth Coffee");
        }
    }
}
