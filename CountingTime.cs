using System;
using System.Collections.Generic;
using System.Text;

namespace CountingTheAmountOfTime
{
    public static class CountingTime
    {
        public static void CountTime()
        {
            
            TimeSpan time = new TimeSpan();
            Console.WriteLine("Для выхода нажмите \"ctrl + Q\"");
            Console.WriteLine("Введите время в формате: чч:мм");
            while ((Console.ReadKey().Modifiers != ConsoleModifiers.Control && Console.ReadKey(true).Key != ConsoleKey.Q))
            {

                TimeSpan inputTime = TimeSpan.Parse(Console.ReadLine());
                time += inputTime;

            }
            Console.WriteLine($"{time.Hours:d2}:{time.Minutes:d2}");
        }
    }
}


