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
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine(number + " x " + i + " = " + result);
        }
        
        
        
        

    }
}