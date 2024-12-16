using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit To Celsius");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(32)); 

            Console.WriteLine("Celsius To Fahrenheit");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(0));
        }
    }
}
