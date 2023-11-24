using System;

class Calculator
{
    static void Main()
    {
        
        //Run the program
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Calculator");
            double num1 = GetNumber("Enter the first number: ");
            char op = GetOperator();
            double num2 = GetNumber("Enter the second number: ");

            double result = PerformCalculation(num1, op, num2);

            Console.WriteLine($"Result: {result}");
            //Exit the program when user chooses no
            if (!MoreCalculations())
            {
                break;
            }
        }
    }

    // Method to get a valid number from the user
    static double GetNumber(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    // Method to get a valid operator from the user
    static char GetOperator()
    {
        while (true)
        {
            Console.Write("Enter the operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (op == '+' || op == '-' || op == '*' || op == '/')
            {
                return op;
            }
            else
            {
                Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /).");
            }
        }
    }

    // Method to perform the calculation based on the operator
    static double PerformCalculation(double num1, char op, double num2)
    {
        switch (op)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                // Return a default value in case of division by zero
                else
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number.");
                    return 0; 
                }
            // Return a default value in case of an invalid operator
            default:
                Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /).");
                return 0; 
        }
    }

    // Method to ask the user if they want to perform another calculation
    static bool MoreCalculations()
    {
        char key;

        do
        {
            Console.Write("Do you want to perform another calculation? (y/n): ");
            key = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (key != 'y' && key != 'n')
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }
        } while (key != 'y' && key != 'n');

        return key == 'y';
    }
}