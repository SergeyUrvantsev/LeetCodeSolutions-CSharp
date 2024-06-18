using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Hard._273._Integer_to_English_Words
{
    public class NumberToWords
    {
        private static readonly string[] _lessThanTwenty = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static readonly string[] _tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private static readonly string[] _thousands = { "", "Thousand", "Million", "Billion" };

        public string Solve(int num)
        {
            if (num == 0) return "Zero";

            int i = 0;
            var words = new StringBuilder();

            while (num > 0)
            {
                if (num % 1000 != 0)
                {
                    var segment = ConvertThreeDigits(num % 1000);
                    words.Insert(0, segment + _thousands[i] + " ");
                }
                num /= 1000;
                i++;
            }

            return words.ToString().Trim();
        }

        private string ConvertThreeDigits(int num)
        {
            var result = new StringBuilder();

            if (num >= 100)
            {
                result.Append(_lessThanTwenty[num / 100] + " Hundred ");
                num %= 100;
            }

            if (num >= 20)
            {
                result.Append(_tens[num / 10] + " ");
                num %= 10;
            }

            if (num > 0)
            {
                result.Append(_lessThanTwenty[num] + " ");
            }

            return result.ToString();
        }
    }
}
