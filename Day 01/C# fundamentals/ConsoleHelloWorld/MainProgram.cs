using ConsoleHelloWorld;

class MainProgram
{
    // Inner method
    public static void PrintLine(string message)
    {
        Console.WriteLine("\nHello " + message + " Welcome!");
    }

    public static void PrintAge(int age)
    {
        while (true)
        {
            if (age > 18)
            {
                Console.WriteLine("\nYou're eligible for this project");

                Console.Write("\nChoose an option:\n1. Calculator program\n2. Tables\n3. Fibonacci\n4. Exit\nEnter your choice (1-4): ");
                string response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        CalculatorProgram.StartCalculator();
                        break;

                    case "2":
                        TablesProgram.MultipleProgram();
                        break;

                    case "3":
                        Fibonacci.FibonacciProgram();
                        break;

                    case "4":
                        Console.WriteLine("\nThank you for visiting!!");
                        return; // Exit the loop and the method

                    default:
                        Console.WriteLine("\nInvalid option. Please enter a valid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nBetter Luck Next Time..!");
                return; // Exit the loop and the method
            }
        }
    }


    // Main Method
    public static void Main()
    {
        Console.WriteLine("Please Enter Your Name: ");
        string name = Console.ReadLine();

        PrintLine(name);
        Console.WriteLine("\nPlease Enter Your Age: ");
        int age;

        // Ensure that the age input is a valid integer
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for age.");
            Console.WriteLine("\nPlease Enter Your Age: ");
        }

        PrintAge(age);
    }
}
