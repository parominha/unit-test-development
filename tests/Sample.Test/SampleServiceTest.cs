using Sample.Extensions;
using System;
using Xunit;

namespace Sample.Test
{
    public class SampleServiceTest
    {
        private readonly SampleService _sampleService;

        public SampleServiceTest()
        {
            //arrange (qualquer tipo de variável necessária para montar o teste)
            _sampleService = new SampleService();
        }

        [Theory]
        [InlineData(1, 1, 1, 1, 1, 1, 10)]
        [InlineData(10, 10, 10, 10, 10, 10, 100)]
        [InlineData(100, 2, 5, 7, 9, 10, 9)]
        public void Subtract_MultipleValues_ReturnFalse(decimal value1, decimal value2, decimal value3, decimal value4, decimal value5, decimal value6, decimal total)
        {
            //act
            var result = _sampleService.Subtract(value1, value2, value3, value4, value5, value6);

            //assert
            Assert.NotEqual(result, total);
        }

        [Theory]
        [InlineData(1, 1, 1, 1, 1, 1, -4)]
        [InlineData(10, 10, 10, 10, 10, 10, -40)]
        [InlineData(100, 2, 5, 7, 9, 10, 67)]

        public void Subtract_MultipleValues_ReturnSuccess(decimal value1, decimal value2, decimal value3, decimal value4, decimal value5, decimal value6, decimal total)
        {
            //act
            var result = _sampleService.Subtract(value1, value2, value3, value4, value5, value6);

            //assert
            Assert.Equal(result, total);
        }

        [Theory]
        [InlineData(2, 4, 6, 8, 12, 2, 5)]
        [InlineData(2, 4, 6, 8, 12, -2, 3)]
        [InlineData(2, 4, 6, 8, 12, 0, 6)]
        public void Sum_MultipleValues_ReturnFalse(decimal value1, decimal value2, decimal value3, decimal value4, decimal value5, decimal value6, decimal total)
        {
            //act
            var result = _sampleService.Sum(value1, value2, value3, value4, value5, value6);

            //assert
            Assert.NotEqual(result, total);
        }

        [Theory]
        [InlineData(2, 4, 6, 8, 12, 2, 34)]
        [InlineData(2, 4, 6, 8, 12, -2, 30)]
        [InlineData(2, 4, 6, 8, 12, 0, 32)]
        public void Sum_MultipleValues_ReturnSuccess(decimal value1, decimal value2, decimal value3, decimal value4, decimal value5, decimal value6, decimal total)
        {
            //act
            var result = _sampleService.Sum(value1, value2, value3, value4, value5, value6);

            //assert
            Assert.Equal(result, total);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsEven_ValuesLessThan3_ReturnTrue(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsEven(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.True(result);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(1)]
        public void IsEven_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsEven(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(1)]
        public void IsOdd_ValuesLessThan3_ReturnTrue(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.True(result);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsOdd_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

    }
}
