using System;


namespace Task_4
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Введiть число мiсяцiв: ");
            int m = Convert.ToInt32(Console.ReadLine());
            DateTime currentDate = DateTime.Now;
            DateTime unknownDate = currentDate.AddMonths(-m);
            Console.WriteLine("Невiдома дата: " + unknownDate.ToString("dd/MM/yyyy"));
        }
    }
}
