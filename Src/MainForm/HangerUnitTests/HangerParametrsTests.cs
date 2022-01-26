using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Hangers;

namespace HangerUnitTests
{
    [TestFixture]
    public class HangerParametrsTests
    {
        private  HangerParametrs DefaultParameters =>
            new HangerParametrs()
            {
                Height = 230,
                Length = 390,
                Width = 5,
                InnerHeight = 230,
                InnerRadius = 15,
                LengthCenterRecess = 390,
                OuterRadius = 15,
                RecessRadius = 3
            };

        #region PositiveTests
        
        [TestCase(230, HangerParametersType.Height,
            Description = "Positive test getter Height")]
        [TestCase(390, HangerParametersType.Length,
            Description = "Positive test getter Length")]
        [TestCase(5, HangerParametersType.Width,
            Description = "Positive test getter Width")]
        [TestCase(110, HangerParametersType.InnerHeight,
            Description = "Positive test getter InnerHeight")]
        [TestCase(17, HangerParametersType.InnerRadius,
            Description = "Positive test getter InnerRadius")]
        [TestCase(130, HangerParametersType.LengthCenterRecess,
            Description = "Positive test getter LengthCenterRecess")]
        [TestCase(30, HangerParametersType.OuterRadius,
            Description = "Positive test getter OuterRadius")]
        [TestCase(4, HangerParametersType.RecessRadius,
            Description = "Positive test getter RecessRadius")]
        public void TestsCorrectValueGetSet(int correctValue, HangerParametersType parameter)
        {
            // Arrange
            var defaultParameters = DefaultParameters;
            var expected = correctValue;

            // Act
            var propertyInfo = typeof(HangerParametrs).
                GetProperty(parameter.ToString());
            propertyInfo.SetValue(defaultParameters, correctValue);

            var actual = propertyInfo.GetValue(defaultParameters);

            //Assert
            Assert.AreEqual(expected, actual, $"{nameof(propertyInfo)}" +
                                              $"returns wrong value");
        }
        #endregion

        #region NegativeTests

        [TestCase(1, HangerParametersType.InnerRadius,
            TestName = "InnerRadius value less than range")]
        [TestCase(700, HangerParametersType.InnerRadius,
            TestName = "InnerRadius value over than range")]
        [TestCase(1, HangerParametersType.Height,
            TestName = "Height value less than range")]
        [TestCase(700, HangerParametersType.Height,
            TestName = "Height value over than range")]
        [TestCase(1, HangerParametersType.Length,
            TestName = "Length value less than range")]
        [TestCase(700, HangerParametersType.Length,
            TestName = "Length value over than range")]
        [TestCase(1, HangerParametersType.Width,
            TestName = "Width value less than range")]
        [TestCase(700, HangerParametersType.Width,
            TestName = "Width value over than range")]
        [TestCase(1, HangerParametersType.InnerHeight,
            TestName = "Inner Height value less than range")]
        [TestCase(700, HangerParametersType.InnerHeight,
            TestName = "Inner Height value over than range")]
        [TestCase(2, HangerParametersType.OuterRadius,
            TestName = "Outer Radius value less than range")]
        [TestCase(700, HangerParametersType.OuterRadius,
            TestName = "Outer Radius value over than range")]
        [TestCase(1, HangerParametersType.RecessRadius,
            TestName = "Recess Radius value less than range")]
        [TestCase(700, HangerParametersType.RecessRadius,
            TestName = "Recess Radius value over than range")]
        [TestCase(1, HangerParametersType.LengthCenterRecess,
            TestName = "Length Center Recess value less than range")]
        [TestCase(700, HangerParametersType.LengthCenterRecess,
            TestName = "Length Center Recess value over than range")]
        public void TestGetErrors_HaveErrorsValue(int wrongValue,HangerParametersType type)
        {
            var expected = new HangerParametrs
            {
                InnerRadius = wrongValue,
                Height = wrongValue,
                InnerHeight = wrongValue,
                Length = wrongValue,
                LengthCenterRecess = wrongValue,
                OuterRadius = wrongValue,
                RecessRadius = wrongValue,
                Width = wrongValue
            };
            var error =
                expected.ErrorsDictionary[type];
            Assert.Throws<ArgumentException>(() =>
            {
                if (error == expected.ErrorsDictionary[type])
                {
                    throw new ArgumentException();
                }

            },"Value out of range");
        }
        #endregion
    }
}
