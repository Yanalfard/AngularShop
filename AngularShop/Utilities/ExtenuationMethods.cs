using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularShop.Utilities
{
    public static class ExtenuationMethods
    {
        private static Random ran = new Random();

        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            return source.OrderBy<T, int>((item) => ran.Next());
        }
    }
}
