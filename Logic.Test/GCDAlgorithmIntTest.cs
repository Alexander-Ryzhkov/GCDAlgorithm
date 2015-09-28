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

        [TestMethod]
        public void EuclidTest_FourInts()
        {
            int arrange = 6;
            int x = 48, y = 144, z = 18, w = 180;

            int act = GCDAlgorithmInt.Euclid(x, y, z, w);

            Assert.AreEqual(arrange, act);

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

        [TestMethod]
        public void BinaryTest_FiveInts()
        {
            int arrange = 13;
            int x = 65, y = 169, z = 26, w = 182, t = 91;

            int act = GCDAlgorithmInt.Binary(x, y, z, w, t);

            Assert.AreEqual(arrange, act);

        }
    }
}
