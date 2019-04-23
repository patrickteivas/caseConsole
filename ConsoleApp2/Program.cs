using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static Random random = new Random();
        
        static void Main(string[] args)
        {
            App app = new App();
            app.loop();
        }

        static ConsoleColor getRandomColor()
        {
            Array values = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)values.GetValue(random.Next(values.Length));
        }
    }
}