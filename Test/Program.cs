using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int twoDigitNamber = int.Parse(Console.ReadLine());
            int tensDigit = twoDigitNamber / 10;
            int unitsDigit = twoDigitNamber % 10;
            int cum = tensDigit + unitsDigit;
            if (cum % 2 == 0)
            {
                Console.WriteLine("Парна");
            }
            else
            {
                Console.WriteLine("Непарна");
            }
        }
    }
}
