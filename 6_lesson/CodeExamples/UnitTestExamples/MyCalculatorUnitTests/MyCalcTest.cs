using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;

namespace MyCalculatorUnitTests
{
    [TestClass]
    public class MyCalcTest
    {
        [TestMethod]
        public void Sum_10and20_30retun()
        {
            //arrange
            int firstNumber = 10;
            int secondNumber = 20;
            int expected = 30;

            //act
            MyCalc myCalc = new MyCalc();

            int actual = myCalc.Sum(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
