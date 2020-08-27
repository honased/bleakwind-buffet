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
    public class CandlehearthCoffee
    {
        private bool ice            = false;
        private bool decaf          = false;
        private bool roomForCream   = false;
        private Size size           = Size.Small;

        /// <summary>
        /// Gets and sets if ice should be added.
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
        /// Gets and sets if the coffee should be decaf.
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
        /// Gets and sets if cream should be added.
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
        /// Gets and sets the size of the drink.
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
        /// Gets the price of the drink.
        /// </summary>
        public double Price
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
                        throw new Exception("Err: Can't get the price of a drink for a size that doesn't exist.");
                }
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        public uint Calories
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
                        throw new Exception("Err: Can't get the calories of a drink for a size that doesn't exist.");
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

            return sizeString + (Decaf ? " Decaf Candlehearth Coffee" : " Candlehearth Coffee");
        }
    }
}
