/*
 * Author: Eric Honas
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Thugs T-Bone entree.
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        public double Price
        {
            get
            {
                return 6.44;
            }
        }

        /// <summary>
        /// The calories of the entre.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 982;
            }
        }

        /// <summary>
        /// Special instructions for how to prepare the drink.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// Returns the nicely formatted name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
