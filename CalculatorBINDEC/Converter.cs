using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBINDEC
{
    internal class Converter
    {
        public static string ToDecimal(string input)
        {
            return Convert.ToInt64(input, 2).ToString();
        }
        public static string ToBinary(string input)
        {
            return Convert.ToString(Convert.ToInt64(input), 2);
        }
    }
}
