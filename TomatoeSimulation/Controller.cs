using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoeSimulation
{
    class Controller
    {
        private Simulation simulation;
        private SimulationView view;

        public Controller(Simulation simulation, SimulationView view)
        {
            this.simulation = simulation;
            this.view = view;
        }

        public void SetUp()
        {
            simulation.Clear();
            simulation.SetRandomRipe();
            simulation.SetRandomRipe();
            view.Clear();
            view.AddRow(simulation.GetTomatoeBox(), simulation.CurrentStep);
        }

        public void Step()
        {
            simulation.Step();
            view.AddRow(simulation.GetTomatoeBox(), simulation.CurrentStep);
        }

        public void Run(int numberOfSteps)
        {
            if (numberOfSteps < 0)
            {
                numberOfSteps = 0;
            }
            for (int i = 0; i < numberOfSteps; ++i)
            {
                Step();
            }
        }
    }
}
