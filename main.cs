using System;
class Program{
    static void Main(string[] args){

    bool conChoice = false;
        while (!conChoice){  
        Console.Write("Select activity from 1 - 5: ");
        string choices = Console.ReadLine();

        if(choices.ToLower() == "exit"){
            Console.Write("Closing program...");
            break;
        }

         if (!int.TryParse(choices, out int actchoice)){
            Console.WriteLine("Invalid input.");
            continue;
        }

        switch (choices)
            {
                case "1":
                    Activity1();
                    break;
                case "2":
                    Activity2();
                    break;
                case "3":
                    Activity3();
                    break;
                case "4":
                    Activity4();
                    break;
                case "5":
                    Activity5();
                    break;
                default:
                    Console.WriteLine("Activity does not exist.");
                    break;
            }
        }
    }

    static void Activity1()
    {
        var go = true;
        Console.WriteLine("Activity 1: PH money denomination");
        while (go)
        {
            Console.Write("Enter a value: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("\nReturning to main menu...");
                break;
            }

            decimal bills;
            if (!decimal.TryParse(input, out bills))
            {
                Console.WriteLine("Invalid denomination. only decimal and integer will be accep");
                continue;
            }

            if (bills == 0.01m || bills == 0.05m || bills == 0.25m)
            {
                Console.WriteLine("No person is found");
            }
            else if (bills == 1)
            {
                Console.WriteLine("Jose Rizal is found in Php." + bills);
            }
            else if (bills == 5)
            {
                Console.WriteLine("Emilio Aguinaldo in Php." + bills);
            }
            else if (bills == 10)
            {
                Console.WriteLine("Andres Bonifacio & Apolinario Mabini is found in Php. " + bills);
            }
            else if (bills == 20)
            {
                Console.WriteLine("Manuel L. Quezon is found in Php. " + bills);
            }
            else if (bills == 50)
            {
                Console.WriteLine("Sergio Osmena is found in Php. " + bills);
            }
            else if (bills == 100)
            {
                Console.WriteLine("Manuel Roxas is found in Php. " + bills);
            }
            else if (bills == 200)
            {
                Console.WriteLine("Diosdado Macapagal is found in Php. " + bills);
            }
            else if (bills == 500)
            {
                Console.WriteLine("Benigno Sr. & Corazon Aquino is found in Php. " + bills);
            }
            else if (bills == 1000)
            {
                Console.WriteLine("Jose Abad Santos, Vicent Lim, & Josefa Llanes Escoda is found in Php. " + bills);
            }
            else
            {
                Console.WriteLine("Invalid Denomination");
            }
        }
    }

    static void Activity2()
    {
        var go2 = true;
        Console.WriteLine("Activity 2: Number divisibility");
        while (go2)
        {
            Console.Write("Please enter a value: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("\nReturning to main menu...");
                break;
            }

            int numhaha;
            if (!int.TryParse(input, out numhaha) || numhaha <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer or 'exit' to return to main menu.");
                continue;
            }

            for (int i = 1; i <= numhaha; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " - FooBar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " - Foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " - Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    static void Activity3() {
    Console.WriteLine("\nActivity 3: Input message");
    Console.Write("Enter something: ");

    var message = "";
    var tuloy = true;

    while (tuloy) {
        string input = Console.ReadLine();
        if (input.ToLower() == "exit") {
            Console.WriteLine("\nClosing program...");
            break;
        } else {
            message += input + " ";
        }
        Console.WriteLine(message);
        Console.Write("Enter something: ");
        }
    }

    static void Activity4() {
    Console.WriteLine("\nActivity 4: Built Pyramid");
    while (true) {
        Console.Write("Enter a positive number: ");
        string input = Console.ReadLine();

        if (input == "0") {
            Console.WriteLine("Closing program...");
            break;
        }

        if (int.TryParse(input, out int numput) && numput > 0) {
            for (int i = 1; i <= numput; ++i) {
                for (int j = 1; j <= numput - i; ++j) {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; ++k) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else {
            Console.WriteLine("Invalid value: " + input);
            }
        }
    }

    static void Activity5() {
    Console.WriteLine("\nActivity 5: Sum vs Append");
    Console.Write("Enter something: ");

    var message1 = "";
    var previousNum = 0; 
    var tuloy1 = true;

    while (tuloy1) {
        string input = Console.ReadLine();
        if (input.ToLower() == "exit") {
            Console.WriteLine("\nClosing program...");
            break;
        }

        bool isNumeric = int.TryParse(input, out int num);

        if (isNumeric) {
            int currentNum = int.Parse(input);
            int sum = previousNum + currentNum;
            Console.WriteLine($"Adding {previousNum} to {currentNum} = {sum}");
            previousNum = currentNum;
        }
        else {
            message1 += input + " ";
        }
        Console.WriteLine("Current message: " + message1);
        Console.Write("Enter something: ");
        }
    }
}