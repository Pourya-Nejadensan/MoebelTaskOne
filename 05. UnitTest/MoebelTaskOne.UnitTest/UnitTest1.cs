using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoebelTaskOne.Domain.Entities;
using System;

namespace MoebelTaskOne.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strSampleString = "A";
            YourNameAsANumber TestYourNameAsANumber = new YourNameAsANumber(strSampleString);
            int strActual = TestYourNameAsANumber.CalcSumOfInputString();
            Assert.AreEqual(expected: 1, actual: strActual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string strSampleString = "Z";
            YourNameAsANumber TestYourNameAsANumber = new YourNameAsANumber(strSampleString);
            int strActual = TestYourNameAsANumber.CalcSumOfInputString();
            Assert.AreEqual(expected: 26, actual: strActual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string strSampleString = "Az";
            YourNameAsANumber TestYourNameAsANumber = new YourNameAsANumber(strSampleString);
            int strActual = TestYourNameAsANumber.CalcSumOfInputString();
            Assert.AreEqual(expected: 27, actual: strActual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string strSampleString = "Test";
            YourNameAsANumber TestYourNameAsANumber = new YourNameAsANumber(strSampleString);
            int strActual = TestYourNameAsANumber.CalcSumOfInputString();
            Assert.AreEqual(expected: 64, actual: strActual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string strSampleString = "Te st";
            YourNameAsANumber TestYourNameAsANumber = new YourNameAsANumber(strSampleString);
            int strActual = TestYourNameAsANumber.CalcSumOfInputString();
            Assert.AreEqual(expected: 64, actual: strActual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string strSampleString = "Ivan";
            YourNameAsANumber TestYourNameAsANumber = new YourNameAsANumber(strSampleString);
            int strActual = TestYourNameAsANumber.CalcSumOfInputString();
            Assert.AreEqual(expected: 46, actual: strActual);
        }
    }
}
