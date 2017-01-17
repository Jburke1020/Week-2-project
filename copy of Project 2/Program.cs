using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_of_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {



            
            
            Console.WriteLine("Welcome to Fortune Teller! Please follow along and answer the questions to learn your fortune.");
            // Read in the following from the user: last name, age, birth month(as an 'int), favorite color ROYGBIV, number of siblings
            Console.WriteLine("To quit the program, please type 'quit' in place of any anwer");



            {


                Console.WriteLine("Please enter your first name.");

                string firstname = Console.ReadLine();





                Console.WriteLine("Please enter your last name.");
                string lastname = Console.ReadLine();

                var f = firstname;
                var l = lastname;

                GreetUser(firstname, lastname);

                Console.WriteLine("Please enter your age.");
                int age = int.Parse(Console.ReadLine());



                Console.WriteLine("Please enter your two digit birth month.");
                int birthmonth = int.Parse(Console.ReadLine());

                int x = birthmonth;

                Console.WriteLine("What is your favorite R O Y G B I V color?  If needed, type Help for a list of these colors.");

                string color = Console.ReadLine();
                color = color.ToLower();
                string c = color;
                if (string.Equals(color, "help"))

                {
                    Console.WriteLine("ROYGBIV stands for Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.WriteLine("Please choose your color");
                }



                else if (c == "Red" || c == "Orange" || c == "Yellow" || c == "Green" || c == "Blue" || c == "Indigo")
                {
                    Console.ReadLine();
                }


                Console.WriteLine("Please enter the number of siblings you have");

                int sibNumber = int.Parse(Console.ReadLine());
                int X = sibNumber;



                Console.Write(f + " " + l);
                Console.Write(" will retire in" + " " + (ShowRetirementAge(age)) + " " + "years");
                Console.Write(" " + "with $"); ShowRetirementMoney(birthmonth); Console.Write(".00");
                Console.Write(", a vacation home in "); ShowLocation(sibNumber);
                ShowTransportation(c);
                RateFortune(x);

            }



        }



        static void UserInputRestart()
        {
        string restart = Console.ReadLine();
    restart = restart.ToLower();
    if (true)
    {
        bool restarting = true;
        var b = restarting;

    }
    int age = int.Parse(Console.ReadLine());
    int birthmonth = int.Parse(Console.ReadLine());
    int x = birthmonth;
    string color = Console.ReadLine();
    color = color.ToLower();
    string c = color;
    int sibNumber = int.Parse(Console.ReadLine());
    int X = sibNumber;

}




static void ShowRetirementMoney(int birthmonth)
{

    if (birthmonth >= 01 && birthmonth <= 04)

    {

        double x = 10000;
        Console.Write(x);

    }
    else if (birthmonth >= 5 && birthmonth <= 8)
    {

        double x = 9000;
        Console.Write(x);
    }
    else if (birthmonth >= 9 && birthmonth <= 12)
    {
        double x = 1000;
        Console.Write(x);
    }
    else
    {
        double x = 0;
        Console.Write(x);
        var u = x;
    }


}


static void RateFortune(int age)
{
    int i = age;

    if (i <= 10)
    {
        Console.WriteLine("You have a great fortune!");

    }

    else if (i >= 11 && i <= 44)
    {
        Console.WriteLine("Your fortune is not too shabby!");

    }

    else if (i >= 45 && i <= 120)
    {
        Console.WriteLine("Sorry your fortune is not the best...");

    }
    else if (i >= 121)
    {
        Console.WriteLine("This may be the worst fortune I've ever told!  You are most likely dead!");

    }


}



static void ShowTransportation(string color)
{


    if (string.Equals(color, "red", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("and a Jet Plane.  ");
    }
    if (string.Equals(color, "orange", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("and a Fancy Scooter.  ");
    }
    if (string.Equals(color, "yellow", StringComparison.CurrentCultureIgnoreCase))

    {
        Console.Write("and a Yellow Truck.  ");
    }

    if (string.Equals(color, "green", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("and a Green Bike.  ");
    }
    if (string.Equals(color, "blue", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("and a Blue Skateboard.  ");
    }

    if (string.Equals(color, "indigo", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("and a Purple Train.  ");
    }

    if (string.Equals(color, "violet", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.Write("and a Violet Bus.  ");
    }
}
static void GreetUser(string firstname, string lastname)

{
    Console.WriteLine("Greetings," + firstname + " " + lastname + ".  I will tell you your fortune!");
}


static int ShowRetirementAge(int age)
{
    int a = age;

    if (a % 2 == 0)
    {
        int z = 10;
        return z;

    }
    else
    {
        int p = 9;
        return p;
    }
}


static void ShowLocation(int sibNumber)   //Method that determines the vacation home relative to even or odd number of siblings
{
    string A = "Akron";
    string B = "Barberton";
    string C = "Cleveland";
    string S = "Stow";
    string F = "Fairlwan";
    string Z = "bad vacation home";


    if (sibNumber > 3)

        Console.WriteLine(A);

    else if (sibNumber == 3)

        Console.WriteLine(B);

    else if (sibNumber == 2)
        Console.WriteLine(C);

    else if (sibNumber == 1)
        Console.WriteLine(S);

    else if (sibNumber == 0)
        Console.WriteLine(F);
    else if (sibNumber < 0)
        Console.WriteLine(Z);
    else
        Console.WriteLine("Please enter a number:");

}


                }
            }
        
    
    


        

