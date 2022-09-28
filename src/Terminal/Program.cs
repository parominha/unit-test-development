using Sample;
using Sample.Extensions;
using System;

namespace Sample.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //var metodos = new SampleService();

            //var numero = 0;

            //metodos.Subtract(numero);

            //metodos.Sum(numero);

            //metodos.IsEven(numero);

            //metodos.IsOdd(numero);

            //metodos.IsPrime(numero);

            //var dateNow = DateTime.Now;
            //double valuePayment = 100.54;
            Console.Write("Digite o seu e-mail: ");
            var emailValue = Console.ReadLine();

            //Console.WriteLine(dateNow.ToStringShortPtBR());
            //Console.WriteLine(valuePayment.ToStringMoneyPtBR());
            Console.WriteLine(emailValue.IsValidMail());

        }
    }
}
