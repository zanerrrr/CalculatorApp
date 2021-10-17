using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            Intro();
        }
        static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Hello! This is my Calculator App!");
            Console.WriteLine("");
            Console.WriteLine("Press 1 or 2 to make the Choice!");
            Console.WriteLine("Here are your Options:");
            Console.WriteLine("1. Calculator "); 
            Console.WriteLine("2. Exit");
            string option = (Console.ReadLine());
            switch (option)
            {
                case "1":
                    Calc();
                    break;
                case "2":
                    Exit();
                    break;
            }    
            Intro();
        }

        static void Calc()
        {
            Console.WriteLine("You have entered the best option - The Calculator and now let's get counting!");
            Console.WriteLine("Press 1 for Addition!");
            Console.WriteLine("Press 2 for Subtraction!");
            Console.WriteLine("Press 3 for Multiplication!");
            Console.WriteLine("Press 4 for Division!");
            string choice = Console.ReadLine();
            int youChoose = int.Parse(choice);
            Console.WriteLine("Enter 1st number: ");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (choice)
            {
                case "1":
                    result = (number_1 + number_2);
                    break;
                case "2":
                    result = (number_1 - number_2);
                    break;
                case "3":
                    if (number_2 == 0)
                    {
                        Console.WriteLine("What's the point?  it will be 0 anyway :(");
                    }
                    else
                    {
                        result = (number_1 * number_2);
                    }
                    break;
                case "4":
                    if (number_2 == 0)
                    {
                        Console.WriteLine("You cannot divide by 0 :(");
                    }
                    else
                    {
                        result = (number_1 / number_2);
                    }
                    break;
                default:
                    Console.WriteLine("Hmm... Something went wrong!");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();

        }

        static void Exit()
        {
            Console.WriteLine("Okay,  bye! Have a good one!");
            Console.ReadLine();
            
        }

    }

}
