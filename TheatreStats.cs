using System;


namespace TheatreStats
{
    class Program { 

        public static void menu()
        {
            Console.WriteLine("-----STATS MENU-----");
            Console.WriteLine("1. Enter theatre information");
            Console.WriteLine("2. Display theatre information:");
            Console.WriteLine("3. Quit");
        }

        static void Main(string[] args)
        {
            // declaring variables
            int[] month = { };
            int[] monthArray;
            int[] day = { };
            int[] dayArray;
            int[] year = { };
            int[] yearArray;
            double[] price = { };
            double[] priceArray;
            int[] customers = { };
            int[] customerArray;
            int choice;
            string input_1;
            string input_2;
            int input_3;
            int input_4;
            int input_5;
            int input_6;
            double input_7;
            string date;
            string name_pad;
            string location_pad;
            int movies;
            string[] name = { };
            string[] nameArray;
            string[] location = { };
            string[] locationArray;
            

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine();
            Console.WriteLine("Welcome to the program TheatreStats! Please select one of the options down below."); //welcome message
            Console.WriteLine();
            menu();
            choice = Convert.ToInt32(Console.ReadLine());

            do
            { 
                if (choice == 1)
                {
                    Console.WriteLine("What is the theatre name?"); //theatre name
                    input_1 = Console.ReadLine();

                    while (input_1 == "")
                    {
                        Console.WriteLine("This section can not be blank. Please enter respective information. ");
                        input_1 = Console.ReadLine();
                    }


                    nameArray = new string[name.Length + 1]; // array for theatre names

                    for (int n = 0; n < name.Length; n++) nameArray[n] = name[n];

                    nameArray[nameArray.Length - 1] = input_1;
                    name = nameArray;




                    Console.WriteLine("What is the theatre location?"); // location
                    input_2 = Console.ReadLine();

                    while (input_2 == "")
                    {
                        Console.WriteLine("This section can not be blank. Please enter respective information");
                        input_2 = Console.ReadLine();
                    }
                    locationArray = new string[location.Length + 1]; //array for location

                    for (int n = 0; n < location.Length; n++) locationArray[n] = location[n];

                    locationArray[locationArray.Length - 1] = input_2;
                    location = locationArray;

                    //date separated into month, day and year

                    Console.WriteLine("What is the number of the month for you theatre information? ");
                    input_3 = Convert.ToInt32(Console.ReadLine());

                    while (input_3 < 1 || input_3 > 12)
                    {
                        Console.WriteLine("Sorry this is not possible, try again!");
                        input_3 = Convert.ToInt32(Console.ReadLine());
                    }

                    monthArray = new int[month.Length + 1]; // array for month

                    for (int n = 0; n < month.Length; n++) monthArray[n] = month[n];

                    monthArray[monthArray.Length - 1] = input_3;
                    month = monthArray;

                    Console.WriteLine("What is the day?");
                    input_4 = Convert.ToInt32(Console.ReadLine());

                    while (input_4 <= 0 || input_4 >= 30)
                    {
                        Console.WriteLine("Sorry this is not possible, try again!");
                        input_4 = Convert.ToInt32(Console.ReadLine());
                    }

                    dayArray = new int[day.Length + 1]; // day array

                    for (int n = 0; n < day.Length; n++) dayArray[n] = day[n];

                    dayArray[dayArray.Length - 1] = input_4;
                    day = dayArray;


                    Console.WriteLine("What is the year?");
                    input_5 = Convert.ToInt32(Console.ReadLine());

                    while (input_5 < 0 || input_5 > 2021)
                    {
                        Console.WriteLine("Sorry this is not possible, try again!");
                        input_5 = Convert.ToInt32(Console.ReadLine());
                    }

                    yearArray = new int[year.Length + 1]; // year array

                    for (int n = 0; n < year.Length; n++) yearArray[n] = year[n];

                    yearArray[yearArray.Length - 1] = input_5;
                    year = yearArray;


                    // customers

                    Console.WriteLine("How many people have come to the theatre?");
                    input_6 = Convert.ToInt32(Console.ReadLine());

                    while (input_6 <= 0)
                    {
                        Console.WriteLine("Sorry this is not possible, try again!");
                        input_6 = Convert.ToInt32(Console.ReadLine());
                    }

                    customerArray = new int[customers.Length + 1];

                    for (int n = 0; n < customers.Length; n++) customerArray[n] = customers[n];
                    customerArray[customerArray.Length - 1] = input_6;
                    customers = customerArray;

                    // price

                    Console.WriteLine("What is the price of the theatre ticket?");
                    input_7 = Convert.ToDouble(Console.ReadLine());

                    while (input_7 < 9.99 || input_7 > 19.99)
                    {
                        Console.WriteLine("Price range must be within $9.99 to $19.99. Please try again!");
                        input_7 = Convert.ToDouble(Console.ReadLine());
                    }

                    priceArray = new double[price.Length + 1];

                    for (int n = 0; n < price.Length; n++) priceArray[n] = price[n];

                    priceArray[priceArray.Length - 1] = input_7;
                    price = priceArray;
                }

                else if (choice == 2) //displaying info
                {
                    if (name.Length == 0) Console.WriteLine("Please enter required information before proceeding!");

                    else
                    {
                        Console.WriteLine("Tabular Report");
                        Console.WriteLine("Theatre Name==Location==Date==Customers==Price");


                        for (int n = 0; n < name.Length; n++)
                        {

                            //name 
                            name_pad= "";

                            for (int i = 0; i < 20 - name[n].Length; i++) name_pad = name_pad + " ";

                            //location
                            location_pad = "";

                            for (int i = 0; i < 15 - location[n].Length; i++) location_pad = location_pad + " ";

                            // display

                            date = "";

                            if (month[n] < 10) date = date + " ";

                            if (day[n] < 10) date = date + " ";
                            date = date + month[n] + "/" + day[n] + "/" + year[n];

                            Console.WriteLine(name[n] + name_pad + location[n] + location_pad + "" + date + "" + customers[n] + "$" + price[n]);

                        }

                        for (int n = 0; n < location.Length; n++) ;

                        for (int n = 0; n < month.Length; n++) ;

                        for (int n = 0; n < day.Length; n++) ;

                        for (int n = 0; n < year.Length; n++) ;

                        for (int n = 0; n < customers.Length; n++) ;

                        for (int n = 0; n < price.Length; n++) ;


                        movies = name.Length;
                        Console.WriteLine("You are seeing " + movies + "  movies");
                        break;

                    }


                }
                else if (choice != 3) Console.WriteLine("Invalid entry!");
            }
            while (choice != 3);
            Console.WriteLine("Thanks for using Theatre Stats! Goodbye! ");

        }
    }
}
         