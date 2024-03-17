using System;

namespace GitExercise
{
    public class Startup
    {
        public static bool CheckCredentials()
        {
            Console.WriteLine("Enter password to gain access: ");
            string password = Console.ReadLine();
            Console.Clear();
            return password == Pass ;
        }
        private const string Pass = "abcd1234"; 
        public static void Main()
        {
            bool isAuthorized = CheckCredentials();
            if (!isAuthorized)
            {
                Console.WriteLine("Access Denied!");
                Console.ReadKey(true);
                return;
            }
            while (true)
            {               
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }

                Console.Write("Option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        OptionsManager.Add(a, b);
                        break;
                    case "s":
                        OptionsManager.Subtract(a, b);
                        break;
                    case "m":
                        OptionsManager.Multiply(a, b);
                        break;
                    case "d":
                        OptionsManager.Devide(a, b);
                        break;
                    case "av":
                        OptionsManager.AbsoluteValue(a, b);
                        break;
                    case "dr":
                        OptionsManager.DevideRemainder(a, b);
                        break;
                    case "pow":
                        OptionsManager.Power(a, b);
                        break;
                    case "fact":
                        OptionsManager.Factorial(a, b);
                        break;
                    case "log":
                        OptionsManager.Log(a, b);
                        break;
                    case "ex":
                        Console.Clear();
                        Console.WriteLine("Bye Bye");
                        Console.ReadKey(true);
                        return;


                }

                Console.WriteLine("Pres any key to close the app...");
                Console.ReadKey(true);
            }
        }
    }
}
