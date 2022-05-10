using System;

namespace TemperatureCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;
            celsius = 0;
            fahrenheit = 9 / 5.0f * celsius + 32;
            Console.WriteLine("{0} Celsius entspricht {1} Fahrenheit", celsius, fahrenheit);
            Console.WriteLine("Celsius: ");
            celsius = Convert.ToSingle(Console.ReadLine());
            fahrenheit = 9 / 5.0f * celsius + 32;
            Console.WriteLine("Fahrenheit:{0}", fahrenheit);
        }
    }
}

