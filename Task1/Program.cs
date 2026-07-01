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
        /*Console.Write("Enter temperature in Celsius: ");
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
        Console.WriteLine("Weather: " + classification);*/
    
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 7 –  Movie Ticket Pricing
        /*Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string category;
        double price;
        if (age >= 0 && age <= 12)
        {
            category = "Child";
            price = 2.000;
        }
        else if (age <= 59)
        {
            category = "Adult";
            price = 5.000;
        }
        else
        {
            category = "Senior";
            price = 3.000;
        }
        
        Console.WriteLine("Category: " + category);
        Console.WriteLine("Ticket Price: " + price + " OMR");*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 8 –  Restaurant Bill with Membership Discount
        /*Console.Write("Enter total bill amount (OMR): ");
        double bill = double.Parse(Console.ReadLine());
        
        Console.Write("Are you a loyalty member? (yes/no): ");
        string memberInput = Console.ReadLine();
        bool   isMember = (memberInput == "yes");
        double discount = 0;
        double finalBill  = bill;
        
        if (bill > 20 && isMember)
        {
            discount = bill * 0.15;
            finalBill = bill - discount;
        }
        
        Console.WriteLine("Original Bill: "  + bill + " OMR");
        Console.WriteLine("Discount: " + discount + " OMR");
        Console.WriteLine("Amount to Pay: "  + finalBill + " OMR");*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 9 –  Day Name Finder
        /*Console.Write("Enter a day number (1-7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 10 –  Mini Calculator
        /*Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter operator (+, -, *, / or %): ");
        char op = char.Parse(Console.ReadLine());
        
        switch (op)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case '/':
                if (num2 == 0)
                    Console.WriteLine("Cannot divide by zero");
                else
                    Console.WriteLine("Result: " + (num1 / num2));
                break;
            case '%':
                if (num2 == 0)
                    Console.WriteLine("Cannot divide by zero");
                else
                    Console.WriteLine("Result: " + (num1 % num2));
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 11 –  Loan Eligibility System
        /*Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your monthly income (OMR): ");
        double income = double.Parse(Console.ReadLine());

        Console.Write("Do you have an existing loan? (yes/no): ");
        bool hasExistingLoan = (Console.ReadLine() == "yes");
        
        if (age >= 21 && age <= 60 && income >= 400 && !hasExistingLoan)
        {
            Console.WriteLine("Loan Approved: You are eligible.");
        }
        else
        {
            if (age < 21 || age > 60)
            {
                Console.WriteLine("Not Eligible: Age is out of range (21–60)");
            }
            else if (income < 400)
            {
                Console.WriteLine("Not Eligible: income too low (minimum of 400 OMR)");
            }
            else if (hasExistingLoan)
            {
                Console.WriteLine("Not Eligible: have an existing loan");
            }
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 12 –  Shipping Cost Calculator
        /*Console.Write("Enter region code (A = Local, B = National, C = International): ");
        char region = char.Parse(Console.ReadLine().ToUpper());
        
        Console.Write("Enter package weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        double baseCost  = 0;
        double extraCost = 0;
        bool validRegion = true;
        
        switch (region)
        {
            case 'A':
                baseCost = 1.000;
                break;
            case 'B':
                baseCost = 3.000;
                break;
            case 'C':
                baseCost = 7.000;
                break;
            default:
                Console.WriteLine("Invalid region");
                validRegion = false;
                break;
        }
        
        if (validRegion)
        {
            if (weight > 10)
            {
                extraCost = 5.000;  
            }
            else if (weight > 5)
            {
                extraCost = 2.000;  
            }

            double totalCost = baseCost + extraCost;
            
            Console.WriteLine("Base Cost: " + baseCost + " OMR");
            Console.WriteLine("Extra Charge: " + extraCost + " OMR");
            Console.WriteLine("Total Cost: " + totalCost + " OMR");
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 13 –  Triangle Type Classifier
        /*Console.Write("Enter side A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter side B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter side C: ");
        double c = double.Parse(Console.ReadLine());
        
        bool isValid = (a + b > c) && (a + c > b) && (b + c > a);

        if (!isValid)
        {
            Console.WriteLine("These sides do NOT form a valid triangle.");
        }
        else
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Valid triangle: Equilateral");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Valid triangle: Isosceles");
            }
            else
            {
                Console.WriteLine("Valid triangle: Scalene");
            }
        }*/
        
        /////////////////////////////////////////////////////////////////////////////////
        
        // Task 14 –  Online Store Checkout
        Console.Write("Enter product code (1 = Headphones, 2 = Keyboard, 3 = Mouse): ");
            int productCode = Convert.ToInt32(Console.ReadLine());

            double unitPrice = 0;
            string productName = "";
            bool   validProduct = true;
            
            switch (productCode)
            {
                case 1:
                    productName = "Headphones";
                    unitPrice   = 8.500;
                    break;
                case 2:
                    productName = "Keyboard";
                    unitPrice   = 12.000;
                    break;
                case 3:
                    productName = "Mouse";
                    unitPrice   = 5.000;
                    break;
                default:
                    Console.WriteLine("Invalid product code");
                    validProduct = false;
                    break;
            }
            
            if (validProduct)
            {
                Console.Write("Enter quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Do you have a discount coupon? (yes/no): ");
                bool hasCoupon = (Console.ReadLine() == "yes");
                
                double subtotal = unitPrice * quantity;
                
                double discount = 0;
                if (hasCoupon && subtotal > 20)
                {
                    discount = subtotal * 0.10;
                }
                double afterDiscount = subtotal - discount;
                double tax           = afterDiscount * 0.05;
                double finalTotal = afterDiscount + tax;
                
                Console.WriteLine("Checkout of: " + productName);
                Console.WriteLine("Subtotal: " + subtotal + " OMR");
                Console.WriteLine("Discount: " + discount + " OMR");
                Console.WriteLine("Tax (5%): " + tax + " OMR");
                Console.WriteLine("Total: " + finalTotal + " OMR");
            }
        
        
        
    }    
}