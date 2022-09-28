using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sample.Extensions
{
    public static class DoubleExtensions
    {
        public static string ToStringMoneyPtBR(this double value)
        {
            return string.Format(new CultureInfo("pt-BR"), "{0:C}", value);
        }
    }
}
