using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempInF) 
        {
            return (tempInF - 32) * (9/5);
        }

        public static double CelsiusToFahrenheit(double tempInC) 
        {
            return (tempInC * 9 / 5) + 32;
        }
    }
}
