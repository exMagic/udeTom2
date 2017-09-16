using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udeTom2
{
    static class Class1
    {
        public static void Summarize(decimal[] values, out decimal max, out decimal min, out decimal average, out decimal sum)
        {
            var list = values.ToList();
            max = list.Max();
            min = list.Min();
            average = list.Average();
            sum = list.Sum();
        }
        
    }
}
