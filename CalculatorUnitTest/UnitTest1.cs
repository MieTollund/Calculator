using NUnit.Framework;

namespace CalculatorUnitTest
{
    public class Tests
    {
        //ARRANGE
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator=new Calculator();
        }

        [Test]
        public void TestAddMethod()
        {
            //ACT og ASSERT
            Assert.That(_calculator.Add(4, 2), Is.EqualTo(6));
        }

        [Test]
        public void TestSubtractMethod()
        {
            Assert.That(_calculator.Subtract(3, 2), Is.EqualTo(1));
        }
        [Test]
        public void TestMultiplyMethod()
        {
            double a = 2;
            double b = 2;
            //ACT
            double resulat = _calculator.Multiply(a, b);

            //ASSERT
            Assert.That(resulat, Is.EqualTo(4));
        }
        [Test]
        public void TestPowerMethod()
        {
            double a = 2;
            double b = 2;
            double resulat = _calculator.Power(a, b);
            Assert.That(resulat, Is.EqualTo(4));
        }

        [Test]
        public void TestDivideMethod()
        {
            
            Assert.That(_calculator.Divide(4,2), Is.EqualTo(2));
        }
    }
}