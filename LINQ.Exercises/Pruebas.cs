using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Exercises
{
    public class Pruebas
    {
        static void Main (string[] Args)
        {




           
            
                IEnumerable<int> result = TestData.Numbers.Select((item, index) => new { Item = item, Index = index }).Where(o => o.Index % 2 == 0).Select(o => o.Item).ToList();

                
            
        }
    }
}
