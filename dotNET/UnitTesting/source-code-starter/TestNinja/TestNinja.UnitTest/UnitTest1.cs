using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void GetOutput_WhenDivOf3and5is0_FizzBuzz()
        {
            FizzBuzz fzbz = new FizzBuzz();
            int input = 15;
            string expectedOutput = "FizzBuzz";
            string result = fzbz.GetOutput(input);
            Assert.AreEqual(expectedOutput, result);
        }

        //[TestMethod]
        //public void GetOutput_WhenDivOnlyOf3is0_Fizz()
        //{
        //    FizzBuzz fzbz = new FizzBuzz();
        //    int input = 9;
        //    string expectedOutput = "Fizz";
        //    string result = fzbz.GetOutput(input);
        //    Assert.AreEqual(expectedOutput, result);
        //}

        //[TestMethod]
        //public void GetOutput_WhenDivOnlyof5is0_Buzz()
        //{
        //    FizzBuzz fzbz = new FizzBuzz();
        //    int input = 10;
        //    string expectedOutput = "Buzz";
        //    string result = fzbz.GetOutput(input);
        //    Assert.AreEqual(expectedOutput, result);
        //}

        //[TestMethod]
        //public void GetOutput_WhenDivOf3Or5isNot0_Nothing()
        //{
        //    FizzBuzz fzbz = new FizzBuzz();
        //    int input = 11;
        //    string expectedOutput = input.ToString();
        //    string result = fzbz.GetOutput(input);
        //    Assert.AreEqual(expectedOutput, result);
        //}
    }
}
