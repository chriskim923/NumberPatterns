using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Tests
{
    [TestClass()]
    public class NumberPatternTests
    {
        [TestMethod()]
        public void IsValidInputEmptyStringTest()
        {
            var emptyTestPattern = new NumberPattern("");
            Assert.IsFalse(emptyTestPattern.IsValid);
        }

        [TestMethod()]
        public void IsValidInputNonIntegerTest()
        {
            var nonIntegerTestPattern = new NumberPattern("1-a-2");
            Assert.IsFalse(nonIntegerTestPattern.IsValid);
        }

        [TestMethod()]
        public void IsValidInputValidTestCase()
        {
            var validTestPattern = new NumberPattern("1-1-2");
            Assert.IsTrue(validTestPattern.IsValid);
        }

        [TestMethod()]
        public void IsConsecutiveIncreasingTest()
        {
            var consecutiveTestPattern = new NumberPattern("1-2-3");
            bool testConsecutive = consecutiveTestPattern.IsConsecutive();
            Assert.IsTrue(testConsecutive);
        }

        [TestMethod()]
        public void IsConsecutiveDecreasingTest()
        {
            var consecutiveTestPattern = new NumberPattern("3-2-1");
            bool testConsecutive = consecutiveTestPattern.IsConsecutive();
            Assert.IsTrue(testConsecutive);
        }

        [TestMethod()]
        public void IsConsecutiveFailTest()
        {
            var nonConsecutiveTestPattern = new NumberPattern("3-2-3");
            bool testConsecutive = nonConsecutiveTestPattern.IsConsecutive();
            Assert.IsFalse(testConsecutive);
        }

        [TestMethod()]
        public void FindDuplicatesTest()
        {
            var expectedTable = new Dictionary<string, int>();
            expectedTable.Add("1", 2);
            expectedTable.Add("3", 1);
            expectedTable.Add("5", 1);
            var TestPattern = new NumberPattern("1-3-1-5");
            var actualTable = TestPattern.FindDuplicates();
            Assert.IsTrue(actualTable.All(e => expectedTable.Contains(e)));
        }
        
    }
}