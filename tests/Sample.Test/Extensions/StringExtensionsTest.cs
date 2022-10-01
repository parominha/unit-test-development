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

        [Fact]
        public void IsValidMail_ReturnTrue()
        {
            var email = "paloma@gmail.com";
            var emailValidate = email.IsValidMail();
            Assert.True(emailValidate);
        }

        [Fact]
        public void IsValidMail_ReturnFalse()
        {
            var email = "paloma.gmail.com";
            var emailValidate = email.IsValidMail();
            Assert.False(emailValidate);
        }
    }
}