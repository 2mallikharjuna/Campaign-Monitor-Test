using System;
using System.Linq;
using System.Collections.Generic;

namespace CampaignMonitorTest
{
    public static class DuplicatesExtension
    {
        /// <summary>
        /// Find the common entities in collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T[] findDuplicates<T>(this IEnumerable<T> source)
        {
            if (source == null || source.Count() == 0)
            {
                throw new ArgumentNullException("Invalid Array input");
            }

            // select the elements that are repeated
            return source.GroupBy(a => a).Where(g => g.Count() > 1)
                             .Select(g => g.Key)
                             .ToArray();
        }
    }
}
