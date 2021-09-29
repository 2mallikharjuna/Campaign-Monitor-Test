using System;
using System.Linq;
using System.Collections.Generic;

namespace CampaignMonitorTest
{
    public static class Divisors
    {
        private static IEnumerable<int> GetDivisors(int n)
        {
            if (n <= 0) { yield return default; }

            for (int i = 1; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    yield return i;
                    if (i != n / i) { yield return n / i; }
                }
            }
        }

        /// <summary>
        /// Finds all the divisors of any positive integer passed as argument.       
        /// </summary>
        public static int[] DivisorFactors(this int num)
        {
            return GetDivisors(num).OrderBy(n => n).ToArray() ;
        }       
        
    }
}
