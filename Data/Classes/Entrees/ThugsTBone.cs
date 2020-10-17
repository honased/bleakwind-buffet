/*
 * Author: Eric Honas
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides a representation of the Thugs T-Bone entree.
    /// </summary>
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// An event triggered when any property is changed.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the entree.
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.44;
            }
        }

        /// <summary>
        /// The calories of the entre.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 982;
            }
        }

        /// <summary>
        /// Special instructions for how to prepare the entree.
        /// </summary>
        public override List<string> SpecialInstructions
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
