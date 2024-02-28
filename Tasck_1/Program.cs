using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            while (restart)
            {
                Console.WriteLine("1: Обчислення ребра куба\n" + "2: Обчислення площi повної поверхнi куба");
                int namber_Switch = int.Parse(Console.ReadLine());
                switch (namber_Switch)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("1: Обчислення ребра за допомогою площi однiєї гранi куба\n" +
                                          "2: Обчислення ребра за допомогою загальної площi куба\n" +
                                          "3: Обчислення ребра за допомогою об'єму куба");
                        int edge_of_a_cube = int.Parse(Console.ReadLine());
                        switch (edge_of_a_cube)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Введiть площю: ");
                                    int area = int.Parse(Console.ReadLine());
                                    Console.WriteLine(Math.Sqrt(area));
                                }
                                break;

                            case 2:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Введiть загальну площю: ");
                                    int total_area = int.Parse(Console.ReadLine());
                                    int area = total_area / 6;
                                    Console.WriteLine(Math.Sqrt(area));
                                }
                                break;

                            case 3:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Введiть об'єм: ");
                                    int volume = int.Parse(Console.ReadLine());
                                    Console.WriteLine(Math.Pow(volume, 1.0 / 3));
                                }
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Такого чсла немає"); break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введiть ребро куба");
                        int rebro = int.Parse(Console.ReadLine());
                        Console.WriteLine(Math.Pow(rebro, 2) * 6);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такого чсла немає"); break;
                }
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
