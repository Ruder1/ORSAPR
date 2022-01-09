using System;
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
            Assert.AreEqual(expected,actual,$"{nameof(DefaultParameters.Height)}"+$" returns wrong value");
        }

        [TestCase(Description = "Positive test getter Length")]
        public void LengthTest_Get()
        {
            var expected = DefaultParameters.Length;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.Length)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter Width")]
        public void WidthTest_Get()
        {
            var expected = DefaultParameters.Width;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.Width)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter InnerHeight")]
        public void InnerHeight_Get()
        {
            var expected = DefaultParameters.InnerHeight;
            var actual =expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.InnerHeight)}" + $" returns wrong value");
        }
        [TestCase(Description = "Positive test getter InnerRadius")]
        public void InnerRadius_Get()
        {
            var expected = DefaultParameters.InnerRadius;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.InnerRadius)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter LengthCenterRecess")]
        public void LengthCenterRecess_Get()
        {
            var expected = DefaultParameters.LengthCenterRecess;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.LengthCenterRecess)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter OuterRadius")]
        public void OuterRadius_Get()
        {
            var expected = DefaultParameters.OuterRadius;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.OuterRadius)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter RecessRadius")]
        public void RecessRadius_Get()
        {
            var expected = DefaultParameters.RecessRadius;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(DefaultParameters.RecessRadius)}" + $" returns wrong value");
        }

        [TestCase( TestName = "Assigning the correct Height")]
        public void Height_CorrectValue_SetSameValue()
        {
            //SetUp
            var hanger = new HangerParametrs() { Height = 230 };
            var actual = hanger.Height;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase( TestName = "Assigning the correct Length")]
        public void Length_CorrectValue_SetSameValue()
        {
            //SetUp
            var hanger = new HangerParametrs() { Length = 390 };
            var actual = hanger.Length;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(TestName = "Assigning the correct OuterRadius")]
        public void OuterRadius_CorrectValue_SetSameValue()
        {
            //SetUp
            var hanger = new HangerParametrs() { InnerRadius = 15 };
            var actual = hanger.InnerRadius;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase( TestName = "Assigning the correct InnerHeight")]
        public void InnerHeight_CorrectValue_SetSameValue()
        {
            //SetUp
            var hanger = new HangerParametrs() { Height = 230 };
            var actual = hanger.Height;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase( TestName = "Assigning the correct LengthCenterRecess")]
        public void LengthCenterRecess_CorrectValue_SetSameValue()
        {
            //SetUp
            var hanger = new HangerParametrs() { Length = 390 };
            var actual = hanger.Length;
            var expected = hanger.Length;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(TestName = "Assigning the correct InnerRadius")]
        public void InnerRadius_CorrectValue_SetSameValue()
        {
            //SetUp
            var hanger = new HangerParametrs() { InnerRadius = 15 };
            var actual = hanger.InnerRadius;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase( TestName = "Assigning the correct RecessRadius")]
        public void RecessRadius_CorrectValue_SetSameValue()
        {
            //SetUp
            var hanger = new HangerParametrs() { RecessRadius = 3 };
            var actual = hanger.RecessRadius;
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase( TestName = "Assigning the correct Width")]
        public void Width_CorrectValue_SetSameValue()
        {
            //SetUp
            var hanger = new HangerParametrs() { Width = 5 };
            var actual = hanger.Width;
            var expected = hanger.Width;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }


        #endregion

        #region NegativeTests

        [TestCase(100, TestName = "Height value less than range")]
        [TestCase(500, TestName = "Height value over than range")]
        public void HeightTest_SetWrong(int wrongHeight)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.Height = wrongHeight; }, "$Value out of range");
        }
        [TestCase(300, TestName = "Length value less than range")]
        [TestCase(500, TestName = "Length value over than range")]
        public void LengthTest_SetWrong(int wrongLength)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.Length = wrongLength; }, "$Value out of range");
        }

        [TestCase(1, TestName = "Width value less than range")]
        [TestCase(7, TestName = "Width value over than range")]
        public void WidthTest_SetWrong(int wrongWidth)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () =>{ DefaultParameters.Width = wrongWidth; }, "$Value out of range");
        }

        [TestCase(10, TestName = "Inner Height value less than range")]
        [TestCase(300, TestName = "Inner Height value over than range")]
        public void InnerHeightTest_SetWrong(int wrongInnerHeight)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.InnerHeight = wrongInnerHeight; }, "$Value out of range");
        }

        [TestCase(10, TestName = "InnerRadius value less than range")]
        [TestCase(35, TestName = "InnerRadius value over than range")]
        public void InnerRadiusTest_SetWrong(int wrongInnerRadius)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.InnerRadius = wrongInnerRadius; }, "$Value out of range");
        }

        [TestCase(2, TestName = "Outer Radius value less than range")]
        [TestCase(50, TestName = "Outer Radius value over than range")]
        public void OuterRadiusTest_SetWrong(int wrongOuterRadius)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.OuterRadius = wrongOuterRadius; }, "$Value out of range");
        }

        [TestCase(1, TestName = "Recess Radius value less than range")]
        [TestCase(7, TestName = "Recess Radius value over than range")]
        public void RecessRadiusTest_SetWrong(int wrongRecessRadius)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.RecessRadius = wrongRecessRadius; }, "$Value out of range");
        }

        [TestCase(100, TestName = "Length Center Recess value less than range")]
        [TestCase(700, TestName = "Length Center Recess value over than range")]
        public void LengthCenterRecessTest_SetWrong(int wrongLengthCenterRecess)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.LengthCenterRecess = wrongLengthCenterRecess; }, "$Value out of range");
        }
        #endregion
    }
}
