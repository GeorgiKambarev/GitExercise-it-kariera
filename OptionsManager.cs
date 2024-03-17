using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Devide",
            "av - Absolute Value"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public static void Devide(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a/b:F2}");
        }
        public static void AbsoluteValue(double a, double b)
        {
            Console.WriteLine($"{a}-{b} = {Math.Abs(a-b)}");
        }
    }
}
