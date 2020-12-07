using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace JenkinsTest.Tests
{
    [TestClass()]
    public class ToTestingClassTests
    {
        [TestMethod()]
        public void ReturnZeroTest()
        {
            var testee = new ToTestingClass();
            Assert.AreEqual(0, testee.ReturnZero());
        }

        [TestMethod()]
        public void ReturnZeroTest2()
        {
            var testee = new ToTestingClass();
            Assert.AreEqual(0, testee.ReturnZero());
        }
    }
}