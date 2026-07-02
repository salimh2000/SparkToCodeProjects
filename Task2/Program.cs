namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        //Task 1 - Countdown Timer
        /*Console.Write("Enter a starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());
            
        for (int i = start; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
            
        Console.WriteLine("Liftoff!");*/
            
        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 2 - Sum of Numbers 1 to N
        /*Console.Write("Enter a positive whole number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
 
        for (int i = 1; i <= n; i++)
        {
            sum += i;   
        }
        
        Console.WriteLine("Sum of 1 to " + n + " is " + sum);*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 3 - Multiplication Table
        /*Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine(number + " x " + i + " = " + result);
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 4 - Password Retry
        /*string Password = "Spark2026";
 
        Console.Write("Enter password: ");
        string input = Console.ReadLine();
        
        while (input != Password)
        {
            Console.WriteLine("Incorrect password, try again");
            Console.Write("Enter password: ");
            input = Console.ReadLine();
        }
        
        Console.WriteLine("Access Granted");*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 5 - Number Guessing Game
        /*int secretNumber = 42;
        int attempts     = 0;
        int guess;
        
        do
        {
            Console.Write("Guess the number: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;
 
            if (guess > secretNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low");
            }
 
        } while (guess != secretNumber);
 
        Console.WriteLine("Correct! attempts : " + attempts);*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 6 - Safe Division Calculator
        /*
        try
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
 
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
 
            double result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: input is not a valid number");
        }*/
        // catch (Exception ex)
        // {
        //     Console.WriteLine("Unexpected error: " + ex.Message);
        // }
        
        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 7 - Repeating Menu with Exit Option
        bool loop = true; 
 
        while (loop)
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
 
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
 
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;
                    case 2:
                        Console.WriteLine("Good day!");
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1, 2, or 3.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid option. Please enter 1, 2, or 3.");
            }
        }

        
        
        
        
    }
}