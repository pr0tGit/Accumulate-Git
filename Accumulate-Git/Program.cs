using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Added
using Accumulate_Git.Helpers;               // AccumulateExtensions

namespace Accumulate_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            // var collection = new int[] { 1, 2, 3 }.Accumulate(x => x * x);
            var collection = new List<string> { "hello", "world" }.Accumulate(x => x.ToUpper());

            Console.ReadLine();
        }
    }
}
