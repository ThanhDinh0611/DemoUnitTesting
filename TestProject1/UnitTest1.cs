using NUnit.Framework;
using QuarterCalculator;

namespace TestProject1
{
    public class Tests
    {
        // Create a QuarterCal object
        private QuarterCal _cal;

        [SetUp]
        public void Setup()
        {
            // Initialise the object
            _cal = new QuarterCal();
        }

        // Create test cases

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Tháng không hợp lệ!", _cal.CalculateQuarter(0));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("Quý 1", _cal.CalculateQuarter(2));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("Quý 2", _cal.CalculateQuarter(5));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("Quý 3", _cal.CalculateQuarter(8));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual("Quý 4", _cal.CalculateQuarter(11));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual("Tháng không hợp lệ!", _cal.CalculateQuarter(13));
        }

    }
}