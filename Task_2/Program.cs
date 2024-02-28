using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            while (restart)
            {
                
                    Console.WriteLine("Введiть двазначне число для перевiрки \nчи є сумма чисел двозначного числа парною ");
                    int twoDigitNamber = int.Parse(Console.ReadLine());
                    int tensDigit = twoDigitNamber / 10;
                    int unitsDigit = twoDigitNamber % 10;
                    int cum = tensDigit + unitsDigit;

                {
                    if (cum % 2 == 0)
                    {
                        Console.WriteLine("Число (" + twoDigitNamber + ") є парним");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Число (" + twoDigitNamber + ") не є парним");
                        Console.ReadLine();
                    }
                }
            
            Console.Clear();
            Console.WriteLine("Натисiнть (N) щоб завершити программу");
            char userInput = Console.ReadKey().KeyChar;
            if (char.ToUpper(userInput) == 'N')
            {
                restart = false;
            }
            Console.Clear();
            }
        }
    }
}
