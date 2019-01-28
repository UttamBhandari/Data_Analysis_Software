using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data_Analysis_Software.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Action on summary class for unit test
/// </summary>
namespace Data_Analysis_Software.Action.Tests
{
    [TestClass()]
    public class SummaryTests
    {
        [TestMethod()]
        public void FindMaxTest()
        {
            int maxValue = Summary.FindMax(new List<string> { "15", "10", "4", "18", "16" });
            Assert.AreEqual(18, maxValue);
        }

        [TestMethod()]
        public void FindMinTest()
        {
            int val = Summary.FindMin(new List<string> { "15", "10", "4", "18", "16" });
            Assert.AreEqual(4, val);
        }

        [TestMethod()]
        public void FindAverageTest()
        {
            double val = Summary.FindAverage(new List<string> { "15", "10", "4", "18", "16" });
            Assert.AreEqual(12, val);
        }

        [TestMethod()]
        public void FindSumTest()
        {
            double val = Summary.FindSum(new List<string> { "15", "10", "4", "18", "16" });
            Assert.AreEqual(63, val);
        }

        [TestMethod()]
        public void ConvertToDate()
        {
            string val = Summary.ConvertToDate("20120102");
            Assert.AreEqual("2012-01-02", val);
        }
    }
}
