using System;
using System.Linq;
using System.Collections.Generic;
using CM.Extentions;
using System.Collections;

namespace CampaignMonitor.Extensions
{
    public static class ExtensionFactory
    {
        public static bool IsNullOrEmpty(this String str)
        {
            return str == null || str == string.Empty;
        }

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

        public static IEnumerable<int> DivisorFactors(this int num)
        {
            return GetDivisors(num).OrderBy(n => n);
        }

        public static double findArea(double a, double b, double c)
        {
            return new Triangle(a, b, c).getArea();
        }

        public static IEnumerable<T> Duplicates<T>(this IEnumerable<T> source)
        {
            if (source == null || source.Count() == 0 )
            {
                throw new ArgumentNullException("Invalid Array input");
            }

            // select the elements that are repeated
            return source.GroupBy(a => a).Where(g => g.Count() > 1)
                             .Select(g => g.Key)
                             .ToList();
        }


    }
}
