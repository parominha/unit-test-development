using Sample.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sample.Test.Extensions
{
    public class StringExtensionsTest
    {
        public StringExtensionsTest() { }

        [Theory]
        [InlineData("paloma@gmail.com")]
        [InlineData("paloma@hotmail.com")]
        [InlineData("paloma@email.com")]
        public void IsValidMail_ReturnTrue(string value)
        {
            //arrange
            var email = value;

            //act
            var emailValidate = email.IsValidMail();

            //assert
            Assert.True(emailValidate);
        }

        [Theory]
        [InlineData("paloma.gmail.com")]
        [InlineData("palomahotmail")]
        [InlineData("paloma@")]
        public void IsValidMail_ReturnFalse(string value)
        {
            //arrange
            var email = value;

            //act
            var emailValidate = email.IsValidMail();

            //assert
            Assert.False(emailValidate);
        }
    }
}