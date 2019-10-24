using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoeSimulation
{
    /// <summary>
    /// Represents a tomatoe that can be unripe or ripe.
    /// </summary>
    class Tomatoe
    {
        private bool isRipe = false;

        public bool IsRipe
        {
            get
            {
                return isRipe;
            }
            set
            {
                isRipe = value;
            }
        }
        /// <summary>
        /// Returns the string "*" if the tomatoe is ripe otherwise "o".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (IsRipe)
            {
                return "*";
            }
            return "o";
        }
    }
}
