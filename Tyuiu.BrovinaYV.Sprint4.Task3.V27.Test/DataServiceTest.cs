using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint4.Task3.V27.Lib;

namespace Tyuiu.BrovinaYV.Sprint4.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5]
            {
                {4, 3, 5, 5, 3 },
                {6, 7, 4, 4, 3 },
                {3, 3, 7, 3, 6 },
                {3, 4, 3, 7, 7 },
                {3, 5, 6, 3, 6 }
            };
            Assert.AreEqual(ds.Calculate(array), 8);
        }
    }
}
