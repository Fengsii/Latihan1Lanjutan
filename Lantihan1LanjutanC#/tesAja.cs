using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lantihan1LanjutanC_
{
    internal class tesAja
    {
        List<int> numbers = new List<int> { 1, 12, 25, 3, 5, 7, 9, 8};

        public void UsingwhereCondision()
        {

            var result = numbers.Where(numbers => numbers % 2 == 0 || numbers == 7);
            Console.WriteLine("Bigger than: " + string.Join(",", result));

        }

        public void SortByASCorDESC()
        {
            var resultAsc = numbers.ToList().OrderBy(numbers => numbers);
            var resultDesc = numbers.ToList().OrderByDescending(numbers => numbers);

            Console.WriteLine("Number order by asc : " + string.Join(",", resultAsc));
            Console.WriteLine("Number order by desc : " + string.Join(",", resultDesc));

        }

        public void SumNumber()
        {
            var result = numbers.Sum();
            
            Console.WriteLine("Number SUM : " + string.Join(",", result));

        }

        public void GitFirst()
        {
            var result = numbers.First();

            Console.WriteLine("Number First : " + string.Join(",", result));

        }

    }
}
