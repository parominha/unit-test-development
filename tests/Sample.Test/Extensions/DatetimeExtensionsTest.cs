﻿using Sample.Extensions;
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
        [InlineData("2022-10-10")]
        [InlineData("2002-07-13")]
        [InlineData("1996-04-07")]
        public void Should_DatetimeToStringShortPtBR_ReturnSuccess(DateTime date)
        {
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

        [Fact]
        public void Should_DatetimeToStringShortPtBR_ReturnFalse()
        {
            //arrange
            var dateTest = DateTime.MinValue;

            //act & assert
            Assert.Throws<ArgumentNullException>(() => dateTest.ToStringShortPtBR());
        }
    }
}