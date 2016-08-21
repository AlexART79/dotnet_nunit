using System;
using NUnit.Framework;

namespace lohika.ADM.AAP
{
    [TestFixture]
    public class SimpleCalcBasicTests
    {
        [Test]
        public void Test_Add2and2_Expected4()
        {
            var res = SimpleCalc.Add(2, 2);
            Assert.True(4 == res);
        }

        [Test]
        [Ignore("Not implemented")]
        public void Test_Sub4and4_Expected0()
        {
            throw new NotImplementedException("Not implemented yet...");
        }

        [Test]
        [Repeat(10)]
        public void Test_Mult5and2_Expected10()
        {
            var res = SimpleCalc.Mult(5, 2);
            Assert.AreEqual(10, res);
        }    
        
        [Test]    
        public void test_Div10and2_Expected5()
        {
            var res = SimpleCalc.Div(10, 2);
            Assert.True(4 == res);
        }
    }
}
