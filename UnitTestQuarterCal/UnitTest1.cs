using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuarterCal;

namespace UnitTestQuarterCal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Launch the app
            var app = ApplicationUnderTest.Launch;
        }
    }
}
