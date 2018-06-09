using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulate_Git.Helpers
{
    public static class AccumulateExtensions
    {
        public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
        {            
            return collection.Count() > 0 ? collection.Select(func) : new U[0].ToArray();
        }
    }
}
