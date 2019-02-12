using LINQ.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = TestData.Numbers.Where(n => (n % 2).Equals(0) && n < 0);

        }
    }
}
