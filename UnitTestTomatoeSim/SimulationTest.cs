using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TomatoeSimulation;

namespace UnitTestTomatoeSim
{
    [TestClass]
    public class SimulationTest
    {
        [TestMethod]
        public void SimulationCreateTest()
        {
            // arrange
            Simulation simulation;

            // act
            simulation = new Simulation(4);

            // assert
            Assert.AreEqual(0, simulation.CurrentStep);
            Assert.AreEqual("oooo", simulation.GetTomatoeBox().ToString());
        }

        [TestMethod]
        public void StepTest()
        {
            // arrange
            Simulation simulation = new Simulation(6);
            simulation.SetRipeAt(3);

            // assert
            Assert.AreEqual("ooo*oo", simulation.GetTomatoeBox().ToString());
            Assert.AreEqual(0, simulation.CurrentStep);

            // act
            simulation.Step();

            // assert
            Assert.AreEqual("oo***o", simulation.GetTomatoeBox().ToString());
            Assert.AreEqual(1, simulation.CurrentStep);

            // act
            simulation.Step();

            // assert
            Assert.AreEqual("o*****", simulation.GetTomatoeBox().ToString());
            Assert.AreEqual(2, simulation.CurrentStep);

            // act
            simulation.Step();

            // assert
            Assert.AreEqual("******", simulation.GetTomatoeBox().ToString());
            Assert.AreEqual(3, simulation.CurrentStep);

        }
    }
}
