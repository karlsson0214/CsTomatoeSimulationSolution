using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoeSimulation
{
    /// <summary>
    /// Used to simulate how tomatoes in a row ripens.
    /// </summary>
    public class Simulation
    {
        // number of tomatoes in the box
        private int noTomatoes;
        private TomatoeBox tomatoeBox;
        private Random randomGenerator = new Random();
        // simulation step number
        private int currentStep = 0;

        /// <summary>
        /// Create a simulation for tomatoes in a line in a box.
        /// Each step the neighbours of ripe tomatoes ripens.
        /// </summary>
        public Simulation(int numberOfTomatoes)
        {
            noTomatoes = numberOfTomatoes;
            Clear();
        }
        public int CurrentStep
        {
            get
            {
                return currentStep;
            }
        }
        /// <summary>
        /// Configure initial setup of the box of tomatoes.
        /// 
        /// All tomatoes are unripe.
        /// </summary>
        public void Clear()
        {
            tomatoeBox = new TomatoeBox(noTomatoes);
            currentStep = 0;
        }

        /// <summary>
        /// Make the tomatoe at the specified position ripe.
        /// </summary>
        /// <param name="position"></param>
        public void SetRipeAt(int position)
        {
            tomatoeBox.RipeAt(position);
        }

        /// <summary>
        /// Make a random tomatoe ripe.
        /// </summary>
        public void SetRandomRipe()
        {
            int randomNumber = randomGenerator.Next(noTomatoes);
            tomatoeBox.RipeAt(randomNumber);         
            System.Diagnostics.Debug.WriteLine(tomatoeBox.ToString());           
        }
            
        
        /// <summary>
        /// Returns an object that implements ITomatoeBoxView.
        /// 
        /// The interface limits the access to the TomatoeBox object.
        /// </summary>
        /// <returns></returns>
        public ITomatoeBoxView GetTomatoeBox()
        {
            return tomatoeBox;
        }

        /// <summary>
        /// A step in the simulation.
        /// </summary>
        public void Step()
        {
            // tomatoe to the left and right ripens each time
            TomatoeBox nextBox = new TomatoeBox(noTomatoes);
            for (int i = 0; i < noTomatoes; ++i)
            {
                if (tomatoeBox.IsRipeAt(i))
                {
                    nextBox.RipeAt(i - 1);
                    nextBox.RipeAt(i);
                    nextBox.RipeAt(i + 1);
                }
            }
            tomatoeBox = nextBox;           
            System.Diagnostics.Debug.WriteLine(tomatoeBox.ToString());
            currentStep += 1;
        }
    }
}
