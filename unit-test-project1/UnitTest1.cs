using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using main_project;

namespace unit_test_project1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Process p = new Process();
            double[,] array = { { 1, 1.6 }, { 2, 3.7 }, { 2, 3.3 } };
            double sr = p.ObKol(2, array);

            double expected = 7.0;
            Assert.AreEqual(expected, sr);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Process p = new Process();
            double[,] array = { { 1, 3.4 }, { 2, 5.3 }, { 1, 3.3 }, { 2, 1.2 }, { 2, 1.1 } };
            double sr = p.ObKol(2, array);

            double expected = 7.6;
            Assert.AreEqual(expected, sr);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Process p = new Process();
            double[,] array = { { 1, 4.8 }, { 2, 5.0 }, { 1, 2.8 } };
            double sr = p.ObKol(1, array);

            double expected = 7.6;
            Assert.AreEqual(expected, sr);
        }

    }
}
