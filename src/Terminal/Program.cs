using Sample;
using System;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var metodos = new SampleService();

            var numero = 0;

            metodos.Subtract(numero);

            metodos.Sum(numero);

            metodos.IsEven(numero);

            metodos.IsOdd(numero);

            metodos.IsPrime(numero);

        }
    }
}
