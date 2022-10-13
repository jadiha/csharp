using System;

namespace OOP1stProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Hello User! What is your first name?: "); //prompt
            string name = Console.ReadLine();
            Console.Write("Hello {0}, what is your last name?: ", name);
            string lastName = Console.ReadLine();
            Console.WriteLine("Your full name is {0} {1}", name, lastName);
            Console.WriteLine("Tell me how old you are and I will double it!");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your aged doubled {0}", age * 2);
            Console.Write(Console.Read());
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
            */

            Console.WriteLine("Hello, thanks for using our program Calculate It! We calulate your individual course average based on the percentages of the assesments that you provide. "); //Program description for user

            Console.WriteLine("----------------------------------------------"); // For visuals

            Console.Write("In order to get started, what is your full name?: "); //Prompts user for name
            string name = Console.ReadLine();

            // Prompts user for their marks in 5 sections including the weekly activity, assignment 1, assignment 2, midterm and final mark
            Console.WriteLine("Now, we will be asking you for your marks. Please only enter the digits and not the percentage sign. Have fun! ");

            Console.WriteLine("----------------------------------------------");  // For visuals

            Console.Write("Enter the your weekly activity overall mark: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your assignment 1 mark: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your assignment 2 mark: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your midterm mark: ");
            double n4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your final mark: ");
            double n5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----------------------------------------------");  // For visuals

            // All marks calculated in one line being multiplied by their respective weighting
            double result = ((n1 * 0.1) + (n2 * 0.2) + (n3 * 0.2) + (n4 * 0.2) + (n5 * 0.3));

            //Print statement showing user what their calculated mark is 
            Console.WriteLine("{0}, your calculated mark for the course is {1}%", name, result);

            // User friendliness farewell message 
            Console.Write("Thanks for using Calculate It! Best of luck in your course, you got this :) ");

        }
    }
}
