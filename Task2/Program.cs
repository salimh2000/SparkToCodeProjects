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
        /*bool loop = true; 
 
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
        }*/

        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 8 - Sum of Even Numbers Only
        /*Console.Write("Enter a positive whole number: ");
        int n   = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
 
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine("Sum of even numbers from 1 to " + n + " is " + sum);*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 9 - Validated Positive Number Input
        /*int number = 0; 
        bool valid = false;  
        
        do
        {
            try
            {
                Console.Write("Enter a positive whole number: ");
                number = Convert.ToInt32(Console.ReadLine());
                
                if (number <= 0)
                {
                    Console.WriteLine("Error: The number must be greater than zero.");
                }
                else
                {
                    valid = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: input is not a valid whole number");
            }
 
        } while (!valid);
        
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }
 
        Console.WriteLine("Sum from 1 to " + number + " is " + sum);*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        //Task 10 - Simple ATM Simulation
        int    correctPin = 1234;
        double balance    = 100.000;
 
        int  attempts   = 0;
        bool pinCorrect = false;
        
        while (attempts < 3 && !pinCorrect)
        {
            try
            {
                Console.Write("Enter PIN: ");
                int enteredPin = Convert.ToInt32(Console.ReadLine());
                attempts++;
 
                if (enteredPin == correctPin)
                {
                    pinCorrect = true;
                }
                else
                {
                    int remaining = 3 - attempts;
                    if (remaining > 0)
                        Console.WriteLine("Incorrect PIN " + remaining + " attempts remaining");
                }
            }
            catch (FormatException)
            {
                attempts++;
                int remaining = 3 - attempts;
                Console.WriteLine("Invalid input " + remaining + " attempts remaining");
            }
        }
        
        if (!pinCorrect)
        {
            Console.WriteLine("Card Blocked. Please contact your bank.");
            return; // exits Main, ending the program
        }
 
        Console.WriteLine("PIN accepted. Welcome!");
        
        bool sessionActive = true;
 
        while (sessionActive)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
 
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
 
                switch (choice)
                {
                    case 1: // Deposit
                        try
                        {
                            Console.Write("Enter deposit amount (OMR): ");
                            double depositAmount = double.Parse(Console.ReadLine());
 
                            if (depositAmount <= 0)
                            {
                                Console.WriteLine("Error: Deposit amount must be positive");
                            }
                            else
                            {
                                balance += depositAmount;
                                Console.WriteLine("Deposit successful");
                                Console.WriteLine("New Balance: " + balance + " OMR");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Invalid amount entered");
                        }
                        break;
 
                    case 2: // Withdraw 
                        try
                        {
                            Console.Write("Enter withdrawal amount (OMR): ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
 
                            if (withdrawAmount <= 0)
                            {
                                Console.WriteLine("Error: Withdrawal amount must be positive");
                            }
                            else if (withdrawAmount > balance)
                            {
                                Console.WriteLine("Error: Insufficient funds. Your balance is " + balance + " OMR");
                            }
                            else
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine("Withdrawal successful.");
                                Console.WriteLine("New Balance: " + balance + " OMR");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Invalid amount entered");
                        }
                        break;
 
                    case 3: // Check Balance
                        Console.WriteLine("Current Balance: " + balance + " OMR");
                        break;
 
                    case 4: // Exit 
                        sessionActive = false; 
                        break;
 
                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, 3, or 4");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid option. Please choose 1, 2, 3, or 4");
            }
        }
    }
}