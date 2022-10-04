using Sample.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sample.Test.Extensions
{
    public class DatetimeExtensionsTest
    {
        public DatetimeExtensionsTest() { }

        [Theory]
        [InlineData("13/07/2002")]
        [InlineData("07/04/1996")]
        [InlineData("01/03/1904")]
        public void Should_DatetimeToStringShortPtBR_ReturnSuccess(DateTime date)
        {
            date.ToString("dd/MM/yyyy");

            //arrange
            var dateTest = date;
            var expectedQtdChar = 10;
            var expectedQtdParts = 3;
            var characterSeparatorDate = "/";
            var maxValueMonth = 12;

            //act
            var result = dateTest.ToStringShortPtBR();
            var resultSplit = result.Split(characterSeparatorDate);

            //assert
            Assert.True(int.Parse(resultSplit[1]) <= maxValueMonth);
            Assert.Equal(expectedQtdParts, resultSplit.Length);
            Assert.Equal(expectedQtdChar, result.Length);
        }

        [Theory]
        [InlineData("32/01/1956")]
        [InlineData("01/01/100")]
        [InlineData("02/16/2002")]
        public void Should_DatetimeToStringShortPtBR_ReturnFalse(DateTime date)
        {
            //arrange
            var dateTest = date;

            //act & assert
            Assert.Throws<ArgumentNullException>(() => dateTest.ToStringShortPtBR());

        }
    }
}