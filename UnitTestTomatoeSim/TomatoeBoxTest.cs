
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TomatoeSimulation;

namespace UnitTestTomatoeSim
{
    [TestClass]
    public class TomatoeBoxTest
    {
        [TestMethod]
        public void CreateTomatoeBoxTest()
        {
            // arrange
            TomatoeBox tomatoeBox;

            // act
            tomatoeBox = new TomatoeBox(5);

            // assert
            Assert.AreEqual("ooooo", tomatoeBox.ToString());              
        }

        [TestMethod]
        public void RipeAtTest()
        {
            // arrange
            TomatoeBox tomatoeBox = new TomatoeBox(7);

            // act
            tomatoeBox.RipeAt(0);
            tomatoeBox.RipeAt(2);
            tomatoeBox.RipeAt(6);

            // assert
            Assert.AreEqual("*o*ooo*", tomatoeBox.ToString());
        }
        [TestMethod]
        public void IsRipeAtTest()
        {
            // arrange
            TomatoeBox tomatoeBox = new TomatoeBox(7);
            tomatoeBox.RipeAt(0);
            tomatoeBox.RipeAt(2);
            tomatoeBox.RipeAt(6);

            // Act as parameter 2 in assert

            // Assert 
            Assert.AreEqual(true, tomatoeBox.IsRipeAt(0));
            Assert.AreEqual(false, tomatoeBox.IsRipeAt(1));
            Assert.AreEqual(true, tomatoeBox.IsRipeAt(2));
            Assert.AreEqual(false, tomatoeBox.IsRipeAt(3));
            Assert.AreEqual(false, tomatoeBox.IsRipeAt(4));
            Assert.AreEqual(false, tomatoeBox.IsRipeAt(5));
            Assert.AreEqual(true, tomatoeBox.IsRipeAt(6));
        }

        [TestMethod]
        public void RipeAtOutOfRangeTest()
        {
            // arrange
            TomatoeBox tomatoeBox = new TomatoeBox(4);

            // act
            tomatoeBox.RipeAt(-1);
            tomatoeBox.RipeAt(4);

            // assert
            Assert.AreEqual("oooo", tomatoeBox.ToString());
        }

        [TestMethod]
        public void IsRipeAtOutOfRangeTest()
        {
            // arrange
            TomatoeBox tomatoeBox = new TomatoeBox(4);
            tomatoeBox.RipeAt(0);

            // assert
            Assert.AreEqual(false, tomatoeBox.IsRipeAt(-1));
            Assert.AreEqual(false, tomatoeBox.IsRipeAt(4));

            
        }
    }
}
