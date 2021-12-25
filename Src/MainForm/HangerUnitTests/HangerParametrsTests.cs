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
        private HangerParametrs DefaultParameters =>
            new HangerParametrs()
            {
                Height = 230,
                Length = 390,
                Width = 5,
                InnerHeight = 110,
                InnerRadius = 15,
                LengthCenterRecess = 292,
                OuterRadius = 30,
                RecessRadius = 3
            };

        #region PositiveTests

        [TestCase(Description = "Positive test getter Height")]
        public void HeightTest_Get()
        {
            var expected = DefaultParameters.Height;
            var hanger = DefaultParameters;
            var actual = expected;
            Assert.AreEqual(expected,actual,$"{nameof(hanger.Height)}"+$" returns wrong value");
        }

        [TestCase(Description = "Positive test getter Length")]
        public void LengthTest_Get()
        {
            var expected = DefaultParameters.Length;
            var hanger = DefaultParameters;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(hanger.Length)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter Width")]
        public void WidthTest_Get()
        {
            var expected = DefaultParameters.Width;
            var hanger = DefaultParameters;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(hanger.Width)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter InnerHeight")]
        public void InnerHeight_Get()
        {
            var expected = DefaultParameters.InnerHeight;
            var hanger = DefaultParameters;
            var actual = hanger.InnerHeight;
            Assert.AreEqual(expected, actual, $"{nameof(hanger.InnerHeight)}" + $" returns wrong value");
        }
        [TestCase(Description = "Positive test getter InnerRadius")]
        public void InnerRadius_Get()
        {
            var expected = DefaultParameters.InnerRadius;
            var hanger = DefaultParameters;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(hanger.InnerRadius)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter LengthCenterRecess")]
        public void LengthCenterRecess_Get()
        {
            var expected = DefaultParameters.LengthCenterRecess;
            var hanger = DefaultParameters;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(hanger.LengthCenterRecess)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter OuterRadius")]
        public void OuterRadius_Get()
        {
            var expected = DefaultParameters.OuterRadius;
            var hanger = DefaultParameters;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(hanger.OuterRadius)}" + $" returns wrong value");
        }

        [TestCase(Description = "Positive test getter RecessRadius")]
        public void RecessRadius_Get()
        {
            var expected = DefaultParameters.RecessRadius;
            var hanger = DefaultParameters;
            var actual = expected;
            Assert.AreEqual(expected, actual, $"{nameof(hanger.RecessRadius)}" + $" returns wrong value");
        }

        [TestCase(230, TestName = "Assigning the correct Height")]
        public void Height_CorrectValue_SetSameValue(int actual)
        {
            //SetUp
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(390, TestName = "Assigning the correct Length")]
        public void Length_CorrectValue_SetSameValue(int actual)
        {
            //SetUp
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(30, TestName = "Assigning the correct OuterRadius")]
        public void OuterRadius_CorrectValue_SetSameValue(int actual)
        {
            //SetUp
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(110, TestName = "Assigning the correct InnerHeight")]
        public void InnerHeight_CorrectValue_SetSameValue(int actual)
        {
            //SetUp
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(292, TestName = "Assigning the correct LengthCenterRecess")]
        public void LengthCenterRecess_CorrectValue_SetSameValue(int actual)
        {
            //SetUp
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(15, TestName = "Assigning the correct InnerRadius")]
        public void InnerRadius_CorrectValue_SetSameValue(int actual)
        {
            //SetUp
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(3, TestName = "Assigning the correct RecessRadius")]
        public void RecessRadius_CorrectValue_SetSameValue(int actual)
        {
            //SetUp
            var expected = actual;
            //Assert
            Assert.AreEqual(expected, actual, "The values are the not same");
        }

        [TestCase(5, TestName = "Assigning the correct Width")]
        public void Width_CorrectValue_SetSameValue(int actual)
        {
            //SetUp
            var expected = actual;
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
                () => { DefaultParameters.Length = wrongHeight; }, "$Value out of range");
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
        [TestCase(6, TestName = "Width value over than range")]
        public void WidthTest_SetWrong(int wrongWidth)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () =>{ DefaultParameters.Length = wrongWidth; }, "$Value out of range");
        }

        [TestCase(10, TestName = "Inner Height value less than range")]
        [TestCase(300, TestName = "Inner Height value over than range")]
        public void InnerHeightTest_SetWrong(int wrongInnerHeight)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.Length = wrongInnerHeight; }, "$Value out of range");
        }

        [TestCase(10, TestName = "InnerRadius value less than range")]
        [TestCase(35, TestName = "InnerRadius value over than range")]
        public void InnerRadiusTest_SetWrong(int wrongInnerRadius)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.Length = wrongInnerRadius; }, "$Value out of range");
        }

        [TestCase(20, TestName = "Outer Radius value less than range")]
        [TestCase(50, TestName = "Outer Radius value over than range")]
        public void OuterRadiusTest_SetWrong(int wrongOuterRadius)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.Length = wrongOuterRadius; }, "$Value out of range");
        }

        [TestCase(1, TestName = "Recess Radius value less than range")]
        [TestCase(7, TestName = "Recess Radius value over than range")]
        public void RecessRadiusTest_SetWrong(int wrongRecessRadius)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.Length = wrongRecessRadius; }, "$Value out of range");
        }

        [TestCase(100, TestName = "Length Center Recess value less than range")]
        [TestCase(700, TestName = "Length Center Recess value over than range")]
        public void LengthCenterRecessTest_SetWrong(int wrongLengthCenterRecess)
        {

            //Assert
            Assert.Throws<ArgumentException>(
                () => { DefaultParameters.Length = wrongLengthCenterRecess; }, "$Value out of range");
        }
        #endregion
    }
}
