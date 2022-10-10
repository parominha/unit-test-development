using Sample.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sample.Test.Extensions
{
    public class DoubleExtensionsTest
    {
        [Theory]
        [InlineData(200.00)]
        [InlineData(1500.00)]
        [InlineData(10000.00)]
        public void Should_ToStringMoneyPtBR_ReturnSucess(double value)
        {
            //arrange
            string valueC;

            //act
            valueC = value.ToStringMoneyPtBR();

            //assert
            Assert.Contains("R$", valueC);
        }

    //    [Theory]
    //    [InlineData("a")]
    //    [InlineData("b")]
    //    [InlineData("c")]
    //    public void Should_ToStringMoneyPtBR_ReturnFalse(string value)
    //    {          
    //    }
    }
}
