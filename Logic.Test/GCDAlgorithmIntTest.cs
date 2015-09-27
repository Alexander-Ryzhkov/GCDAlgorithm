using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logic.Test
{
    [TestClass]
    public class GCDAlgorithmIntTest
    {
        //
        //
        //  Testing Euclid
        //
        //
        [TestMethod]
        public void EuclidTest_PositiveInts()
        {
            int arrange = 14;
            int x = 182, y = 238;

            int act = GCDAlgorithmInt.Euclid(x, y);
            Assert.AreEqual(arrange, act);
        }
        
        [TestMethod]
        public void EuclidTest_NegativeInts()
        {
            int arrange = 14;
            int x = -182, y = -238;

            int act = GCDAlgorithmInt.Euclid(x, y);

            Assert.AreEqual(arrange, act);

        }
        
        [TestMethod]
        public void EuclidTest_EqualInts()
        {
            int arrange = 19;
            int x = 19, y = 19;

            int act = GCDAlgorithmInt.Euclid(x, y);

            Assert.AreEqual(arrange, act);

        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void EuclidTest_OverflowException()
        {
            GCDAlgorithmInt.Euclid(int.MinValue, 0);
        }


        //
        //
        //  Testing Binary
        //
        //
        [TestMethod]
        public void BinaryTest_PositiveInts()
        {
            int arrange = 7;
            int x = 91, y = 238;

            int act = GCDAlgorithmInt.Binary(x, y);
            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void BinaryTest_NegativeInts()
        {
            int arrange = 14;
            int x = -182, y = -238;

            int act = GCDAlgorithmInt.Binary(x, y);

            Assert.AreEqual(arrange, act);

        }

        [TestMethod]
        public void BinaryTest_EqualInts()
        {
            int arrange = 19;
            int x = 19, y = 19;

            int act = GCDAlgorithmInt.Binary(x, y);

            Assert.AreEqual(arrange, act);

        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void BinaryTest_OverflowException()
        {
            GCDAlgorithmInt.Binary(int.MinValue, 0);
        }
    }
}
