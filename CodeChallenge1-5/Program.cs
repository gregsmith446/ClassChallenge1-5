using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var callClass = new CompareStrings();

            int result = callClass.CompareString("this", "bear", 4);

            Console.WriteLine(result);
        }
    }

    class CompareStrings
    {
        public int CompareString(string s1, string s2, int sLength)
        {
            // convert both strings to char array
            char[] charArr1 = s1.ToCharArray();
            char[] charArr2 = s2.ToCharArray();

            // initialize an array of ints that will hold the total differences between s1 & s2
            // List<int> charTotal = new List<int>();
            int total = 0;

            // loop through both chars
            for (int i = 0; i < sLength; i++)
            {
                int diff = charArr2[i] - charArr1[i];
                Console.WriteLine("The difference between the 2 chars is {0}.", diff);
                total = Math.Abs(diff) + total;
                // total += diff // shortcut version 
            }

            // Console.WriteLine(total);
            return total;
        }
    }
}
