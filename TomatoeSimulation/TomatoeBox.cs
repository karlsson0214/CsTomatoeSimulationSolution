using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoeSimulation
{
    /// <summary>
    /// The class TomatoeBox represents a box with tomatoes in one single row.
    /// </summary>
    public class TomatoeBox : ITomatoeBoxView
    {
        private Tomatoe [] tomatoes;
        /// <summary>
        /// Create a TomatoeBox with the specified amounts of tomatoes.
        /// The box is filled with tomatoes that is not ripe.
        /// </summary>
        /// <param name="numberOfTomatoes"></param>
        public TomatoeBox(int numberOfTomatoes)
        {
            tomatoes = new Tomatoe[numberOfTomatoes];
            for (int i = 0; i < numberOfTomatoes; ++i)
            {
                tomatoes[i] = new Tomatoe();
            }
        }
        /// <summary>
        /// Returns the number of tomatoes in the box. 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return tomatoes.Length;
        }
        /// <summary>
        /// Make the tomatoe at the given position ripe.
        /// </summary>
        /// <param name="position">Valid values are 1, 2, ..., Size - 1</param>
        public void RipeAt(int position)
        {
            if (0 <= position && position < tomatoes.Length)
            {
                tomatoes[position].IsRipe = true;
            }          
        }
        /// <summary>
        /// Returns true if the tomatoe at the given position is ripe, otherwise false.
        /// If position is out of range it returns false.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool IsRipeAt(int position)
        {
            if (0 <= position && position < tomatoes.Length)
            {
                return tomatoes[position].IsRipe;
            }
            // invalid position value, out of range
            return false;
        }
        /// <summary>
        /// A string that represents the states of the tomatoes in the box.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = "";
            foreach (Tomatoe t in tomatoes)
            {
                str += t.ToString();
            }
            return str;
        }
    }
}
