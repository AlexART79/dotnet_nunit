using System;
using NUnit.Framework;

namespace lohika.ADM.AAP
{
    [TestFixture]
    class SimpleCalcParameterizedTests
    {
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(10, 0, 10)]
        [TestCase(-5, 5, 0)]
        [TestCase(-5, -5, -10)]
        [TestCase(999, 1, 1000)]        
        public void Test_Add(double a, double b, double res)
        {
            Assert.True(SimpleCalc.Add(a, b) == res);
        }

        /// <summary>
        /// Data for test
        /// </summary>
        static object[] DivideCases =
        {
            new object[] { 12, 3, 4 },
            new object[] { 12, 2, 6 },
            new object[] { 12, 4, 3 }
        };

        [Test, TestCaseSource("DivideCases")]
        public void Test_Divide(int a, int b, int res)
        {
            Assert.AreEqual(res, SimpleCalc.Div(a, b));
        }
        
    }
}
