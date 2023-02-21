using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBINDEC
{
    internal class Converter
    {
        private string value;

        public Converter(string value)
        {
           this.value = value;
        }

        public string Value { get => value; }

        public bool ToDecimal(int fromBase)
        {
            if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
            {
                return false;
            }
            
            try
            {
                value = Convert.ToInt64(value, fromBase).ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ToSystem(int fromBase)
        {
            if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
            {
                return false;
            }

            try
            {
                value = Convert.ToString(Convert.ToInt64(value), fromBase);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
