using System;
using System.Runtime.CompilerServices;

namespace OOP_001
{
    internal class Program
    {
        public class MyClass
        {
            public MyClass()
            {
                Property = "Somve vlaue...";
            }
            public string Property { get; init; } = "Some value";

        }
        public struct WeatherObservation
        {
            public DateTime RecordedAt { get; init; }
            public decimal TemperatureInCelsius { get; init; }
            public decimal PressureInMillibars { get; init; }
            public static void Show(decimal temp)
            {
                Console.WriteLine($"test {temp}");
            }

            public override string ToString() =>
                $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
                $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
        }
        static void Main(string[] args)
        {
            //MyClass instance = new MyClass() { Property = "Hellow" };
            //MyClass instance = new MyClass { Property = "Hellow" };
            MyClass instance = new() { Property = "Hellow" };
            //instance.Property = "World";
            var weather = new WeatherObservation
            {
                RecordedAt = DateTime.Parse("28/2/2028 8:30:52 AM"),
                TemperatureInCelsius = 15,
                PressureInMillibars = 998.0m
            };
            Console.WriteLine(weather);
            Console.WriteLine(weather.RecordedAt);
            WeatherObservation.Show(weather.TemperatureInCelsius);
 
        }
    }
}
