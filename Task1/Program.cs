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
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 2 – Rectangle Calculator
        /*Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
            
        double area = length * width;
        double perimeter = 2 * (length + width);
            
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 3 – Even or Odd Checker
        /*Console.Write("Enter a whole number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is even");
        }
        else
        {
            Console.WriteLine(number + " is odd");
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 4 – Voting Eligibility
        /*Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Do you have a valid national ID? (yes/no): ");
        string idInput = Console.ReadLine();
        
        bool hasid = (idInput == "yes");
        if (age >= 18 && hasid)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 5 – Grade Letter Lookup
        /*Console.Write("Enter a grade (A/B/C/D/F): ");
        char grade = char.Parse(Console.ReadLine());
        
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;
            case 'B':
                Console.WriteLine("Very Good");
                break;
            case 'C':
                Console.WriteLine("Good");
                break;
            case 'D':
                Console.WriteLine("Pass");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid grade");
                break;
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 6 – Temperature Converter
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        
        double fahrenheit = (celsius * 9 / 5) + 32;
        
        string classification;
        if (celsius < 10)
        {
            classification = "Cold";
        }
        else if (celsius <= 30)
        {
            classification = "Mild";
        }
        else
        {
            classification = "Hot";
        }
        
        Console.WriteLine("Fahrenheit: " + fahrenheit);
        Console.WriteLine("Weather: "    + classification);
    }
    
    
}