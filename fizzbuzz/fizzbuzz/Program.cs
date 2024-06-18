using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static List<Number> history = new List<Number>();
    static void Main()
    {
        RunMenu();
    }


    static void RunMenu()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Fizz Buzz");
            Console.WriteLine("2. Hist");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Fizz Buzz...");
                    PerformAddition();
                    break;
                case "2":
                    Console.WriteLine("Hist...");
                    PrintHist(history);
                    break;
                case "3":
                    Console.WriteLine("Exiting the program.");
                    continueProgram = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter 1 or 2.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
    static void PrintHist(List<Number> numbers)
    {
        if (numbers.Count <= 0)
            Console.WriteLine("No elements in the list.");
        else
        {
            foreach (var item in numbers)
                Console.WriteLine($"The number {item.NumberIn} is Fizz= {item.IsFizz}, Buzz= {item.IsBuzz}, Fizz Buzz= {item.IsFizzBuzz}");
        }
    }

    static void PerformAddition()
    {
        Console.Write("Enter the number: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input for the first number.");
            return;
        }

        var myNumber= new Number { NumberIn = number, IsFizz = number % 3 == 0, IsBuzz = number % 5 == 0, IsFizzBuzz = number % 3 == 0 && number % 5 == 0 };
        history.Add(myNumber);
        PrintHist(new List<Number>() { myNumber });
    }
}