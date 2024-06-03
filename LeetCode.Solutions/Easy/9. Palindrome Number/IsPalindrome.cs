using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._9._Palindrome_Number
{
    public class IsPalindrome
    {
        //Complexity
        //Time: O(log(n)), где n - количество цифр в числе x.
        //  Это потому, что мы делим число x на 10 в каждой итерации цикла while,
        //  что приводит к уменьшению числа цифр в x вдвое на каждой итерации.
        //Space: O(n), так как мы используем дополнительную память для хранения обратной строки числа.

        public bool Solve_v2(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int reversed = 0;
            while (x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            return x == reversed || x == reversed / 10;
        }

        //Complexity
        //Time: O(n), где n - количество цифр в числе x.
        //Space: O(n), так как мы используем дополнительную память для хранения обратной строки числа.

        public bool Solve_v1(int x) =>
            x.ToString() == new string(x.ToString().Reverse().ToArray());
    }
}
