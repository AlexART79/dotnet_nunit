﻿using System;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace lohika.ADM.AAP
{
    [TestFixture]
    class SimpleCalcParameterizedTests
    {
        [Test, Sequential] // there are also "Combinatorial" and "Pairwise" but they are not relevant for us...
        public void Test_Add_vithValues(
            [Range(1,2,1)]double a, 
            [Values(1,2,3)]double b, 
            [Values(2,4,6)]double expected)
        {
            var res = SimpleCalc.Add(a, b);
            Assert.AreEqual(expected, res, 0, "Actual result {0} is not equal to {1}", res, expected);
        }

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(10, 0, 10)]
        [TestCase(-5, 5, 0)]
        [TestCase(-5, -5, -10)]
        [TestCase(999, 1, 1000)]        
        public void Test_Add_withTestCases(double a, double b, double res)
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
        
        public class MultData
        {
            public static IEnumerable Data {
                get {
                    var TestCases = new List<TestCaseData>();
                    TestCases.Add(new TestCaseData(2, 2, 4).SetName("Test 2 * 4; Expected:  4"));
                    TestCases.Add(new TestCaseData(2, 0, 0).SetName(" 2 * 0 = 0").Ignore("Ignore this case!"));
                    TestCases.Add(new TestCaseData(10, 10, 100).SetName(" 10 * 10 = 100"));

                    return TestCases;                                   
                }
            }
        }     

        [Test]
        [TestCaseSource(typeof(MultData), "Data")]
        public void Test_Mult(double a, double b, double res)
        {
            Assert.True(res == SimpleCalc.Mult(a, b));
        }
    }
}
