//using Microsoft.VisualStudio.TestTools.UnitTesting;
using BTTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework ;

namespace BTTesting.Tests
{
    [TestFixture]
    public class Test
    {
        private Calculator _cal;

        [SetUp]
        public void Setup()
        {
            _cal = new Calculator();
        }

        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(100, true)]
        [TestCase(32766, true)]
        [TestCase(32767, true)]
        [TestCase(32768, true)]
        public void TestTocalCost1(int quantity, bool haveStudentCard)
        {
            var result = _cal.TotalCost(quantity, haveStudentCard);
            Assert.AreEqual(40 * quantity, result);
        }

        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(100, false)]
        [TestCase(32766, false)]
        [TestCase(32767, false)]
        [TestCase(32768, false)]
        public void TestTocalCost2(int quantity, bool haveStudentCard)
        {
            var result = _cal.TotalCost(quantity, haveStudentCard);
            Assert.AreEqual(60 * quantity, result);
        }

        [TestCase(0, true)]
        [TestCase(0, false)]
        public void TestTocalCost3(int quantity, bool haveStudentCard)
        {
            Assert.Throws<Exception>(() => _cal.TotalCost(quantity, haveStudentCard));
        }

        [TestCase(2, true)]
        public void TestTocalCost4(int quantity, bool haveStudentCard)
        {
            var result = _cal.TotalCost(quantity, haveStudentCard);
            Assert.AreEqual(120, result);
        }

        [TestCase(2, false)]
        public void TestTocalCost5(int quantity, bool haveStudentCard)
        {
            var result = _cal.TotalCost(quantity, haveStudentCard);
            Assert.AreEqual(80, result);
        }

        [TestCase(-1, true)]
        [TestCase(-1, false)]
        public void TestTocalCost6(int quantity, bool haveStudentCard)
        {
            Assert.Throws<Exception>(() => _cal.TotalCost(quantity, haveStudentCard));
        }
    }
}