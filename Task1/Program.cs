namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 – Personal Info Card
        /*string name = "Sara";
        int    age = 21;
        double height = 1.65;
        bool   isStudent = true;
                    
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Student: " + isStudent);*/
        
        // Task 2 – Rectangle Calculator
        /*Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
            
        double area = length * width;
        double perimeter = 2 * (length + width);
            
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);*/
        
        // Task 3 – Even or Odd Checker
        Console.Write("Enter a whole number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is even");
        }
        else
        {
            Console.WriteLine(number + " is odd");
        }
        
    }
}