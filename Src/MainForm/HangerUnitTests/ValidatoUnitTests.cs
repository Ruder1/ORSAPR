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
    public class ValidatorUnitTests
    {
        [TestCase(10, 15, 20, HangerParametersType.Height,
            TestName = "Value less than range")]
        [TestCase(100, 1, 50, HangerParametersType.Height,
            TestName = "Value over than range")]
        public void TestValidator_InvalidValue(int invalidValue,
            int minValue, int maxValue, HangerParametersType type)
        {

            Assert.Throws<ArgumentException>(() => ValidatorHangerParametrs.CheckParametrsValue(
                minValue, maxValue, invalidValue,  type), $"value out of range");
        }

        [TestCase(10, 1, 20, HangerParametersType.Height,
            TestName = "Value in the range")]
        public void TestValidator_ValidValue(int validValue,
            int minValue, int maxValue, HangerParametersType type)
        {

            Assert.DoesNotThrow(() => ValidatorHangerParametrs.CheckParametrsValue(minValue,
                maxValue, validValue, type), $"value out of range");
            
        }
    }
}