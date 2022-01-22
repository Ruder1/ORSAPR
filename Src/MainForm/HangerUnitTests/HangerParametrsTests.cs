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
                Height = 210,
                Length = 400,
                Width = 5,
                InnerHeight = 210,
                InnerRadius = 17,
                LengthCenterRecess = 400,
                OuterRadius = 17,
                RecessRadius = 3
            };

        #region PositiveTests

        [TestCase(Description = "Positive test getter Height")]
        public void HeightTest_Get()
        {
            var expected = DefaultParameters.Height;
            var actual = expected;
            Assert.AreEqual(expected,actual,$"{nameof(DefaultParameters.Height)}"
                                            +$" returns wrong value");
        }

        [TestCase(Description = "Positive test getter Length")]
        public void LengthTest_Get()
        {
            var expected = DefaultParameters.Length;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.Length)}" 
                                              + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter Width")]
        public void WidthTest_Get()
        {
            var expected = DefaultParameters.Width;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.Width)}" 
                                              + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter InnerHeight")]
        public void InnerHeight_Get()
        {
            var expected = DefaultParameters.InnerHeight;
            var actual =expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.InnerHeight)}"
                                              + $" returns wrong value");
        }
        [TestCase(Description = "Positive test getter InnerRadius")]
        public void InnerRadius_Get()
        {
            var expected = DefaultParameters.InnerRadius;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.InnerRadius)}"
                                              + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter LengthCenterRecess")]
        public void LengthCenterRecess_Get()
        {
            var expected = DefaultParameters.LengthCenterRecess;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.LengthCenterRecess)}"
                                              + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter OuterRadius")]
        public void OuterRadius_Get()
        {
            var expected = DefaultParameters.OuterRadius;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.OuterRadius)}"
                                              + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter RecessRadius")]
        public void RecessRadius_Get()
        {
            var expected = DefaultParameters.RecessRadius;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.RecessRadius)}"
                                              + $" returns wrong value");
        }

        [TestCase(TestName =
            "Позитивный - Отправить значения по умолчанию")]
        public void TestGetErrors_NoErrorsValue()
        {

            var hangerParameters = DefaultParameters;
            var actual =
                hangerParameters.ErrorsDictionary;

            Assert.IsEmpty(actual, "Словарь не пуст");
        }

        [TestCase(230, TestName = "Assigning the correct Height")]
        public void Height_CorrectValue_SetSameValue(int value)
        {
            //SetUp
            var hanger = new HangerParametrs() { Height = value };
            var actual = hanger.Height;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(390, TestName = "Assigning the correct Length")]
        public void Length_CorrectValue_SetSameValue(int value)
        {
            //SetUp
            var hanger = new HangerParametrs() { Length = value };
            var actual = hanger.Length;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(15,TestName = "Assigning the correct OuterRadius")]
        public void OuterRadius_CorrectValue_SetSameValue(int value)
        {
            //SetUp
            var hanger = new HangerParametrs() { InnerRadius = value };
            var actual = hanger.InnerRadius;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(230, TestName = "Assigning the correct InnerHeight")]
        public void InnerHeight_CorrectValue_SetSameValue(int value)
        {
            //SetUp
            var hanger = new HangerParametrs() { Height = value };
            var actual = hanger.Height;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(390, TestName = "Assigning the correct LengthCenterRecess")]
        public void LengthCenterRecess_CorrectValue_SetSameValue(int value)
        {
            //SetUp
            var hanger = new HangerParametrs() { Length = value };
            var actual = hanger.Length;
            var expected = hanger.Length;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(15,TestName = "Assigning the correct InnerRadius")]
        public void InnerRadius_CorrectValue_SetSameValue(int value)
        {
            //SetUp
            var hanger = new HangerParametrs() { InnerRadius = value };
            var actual = hanger.InnerRadius;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(3, TestName = "Assigning the correct RecessRadius")]
        public void RecessRadius_CorrectValue_SetSameValue(int value)
        {
            //SetUp
            var hanger = new HangerParametrs() { RecessRadius = value };
            var actual = hanger.RecessRadius;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(5, TestName = "Assigning the correct Width")]
        public void Width_CorrectValue_SetSameValue(int value)
        {
            //SetUp
            var hanger = new HangerParametrs() { Width = value };
            var actual = hanger.Width;
            var expected = hanger.Width;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
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
