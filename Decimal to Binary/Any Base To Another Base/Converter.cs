using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Any_Base_To_Another_Base
{
    public class Converter
    {
        private StringHelper _helper;
        public Converter()
        {
            _helper = new StringHelper();
        }
        public decimal ToDecimal(string input,int inputBaseValue)
        {
            double result = 0;
            int j = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int value = Convert.ToInt32(input[j].ToString());
                result += value * Math.Pow(inputBaseValue, i);
                j++;
            }
            return (decimal)result;
        }

        public string ToAnyBase(int inputnumber,int basevalue)
        {
            StringBuilder sb = new StringBuilder();
            string result;
            if (inputnumber != 0)
            {
                int i = 0;
                int rem;
                while (inputnumber != 0)
                {
                    rem = inputnumber % basevalue;
                    sb.Append(rem);
                    inputnumber = inputnumber / basevalue;

                }
                result = _helper.ReverseString(sb.ToString());
            }
            else
            {
                result = "0";
            }

            return result;
        }
    }
}
