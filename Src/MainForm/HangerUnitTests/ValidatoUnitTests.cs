using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangers;
using NUnit.Framework;

namespace HangerUnitTests
{
    [TestFixture]
    class ValidatorUnitTests
    {
        [TestCase(10, 15, 20, TestName = "Value less than range")]
        [TestCase(100, 1, 50, TestName = "Value over than range")]
        public void TestValidator_InvalidValue(int invalidValue,
            int minValue, int maxValue)
        {

            Assert.Throws<ArgumentException>(() => ValidatorHangerParametrs.CheckParametrsValue(minValue,
                maxValue, invalidValue), $"value out of range");
        }

        [TestCase(10, 1, 20, TestName = "Value in the range")]
        public void TestValidator_ValidValue(int validValue,
            int minValue, int maxValue)
        {

            Assert.DoesNotThrow(() => ValidatorHangerParametrs.CheckParametrsValue(minValue,
                maxValue, validValue), $"value out of range");
            
        }
    }
}