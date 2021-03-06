﻿/*
 * Author: Eric Honas
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides a representation of the Fried Miraak side.
    /// </summary>
    public class FriedMiraak : Side
    {
        /// <summary>
        /// An event triggered when any property is changed.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the side.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                bool invoke = size != value;
                size = value;
                if (invoke)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

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
                        return 1.78;

                    case Size.Medium:
                        return 2.01;

                    case Size.Large:
                        return 2.88;

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
                        return 151;

                    case Size.Medium:
                        return 236;

                    case Size.Large:
                        return 306;

                    default:
                        throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Special instructions for how to prepare the side.
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

            return sizeString + " Fried Miraak";
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        public override string Description => "Perfectly prepared hash brown pancakes.";
    }
}
