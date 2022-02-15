using System;
namespace StaticExercise
{
    public class TempConverter
    {
        public TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 0.8;
        }

        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 1.8) + 32;
        }
    }
}
