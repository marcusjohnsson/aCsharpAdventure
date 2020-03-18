using System;

namespace aCsharpAdventure
{
    class MainClass
    {
        
        
        public static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false) {

                /// A Simple switch menu
                Console.WriteLine("### MENU ###########################################");
                Console.WriteLine("1) - An example of a while loop");
                Console.WriteLine("2) - Tells your are by the year you were born");
                Console.WriteLine("3) - Only in it for the lolz");
                Console.WriteLine("4) - Add or Muliply?");
                Console.WriteLine("0) - exits the application");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 0:

                        exit = true;
                        break;

                    case 1:

                        whileLoop();
                        break;

                    case 2:

                        yourAge();
                        break;

                    case 3:

                        tellJoke();
                        break;

                    case 4:

                        addOrMultiply();
                        break;

                    default:

                        Console.WriteLine("Thats not an option");
                        break;

                }
            }

        }

        /// <summary>
        /// An example of a while loop. It prompts for an integer and prints out the digits
        /// </summary>
        static void whileLoop()
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("You chose 1) - An example of a while loop");
            Console.WriteLine("Give me a whole number and I will count to it:");

            int i;
            int myNumber = int.Parse(Console.ReadLine());

            i = 0;
            while (i <= myNumber)
            {
                Console.WriteLine(i);
                i += 1;

            }

            Console.WriteLine("Now thats some good counting...");
        }

        /// <summary>
        /// Prompts for the age of the user. Calculates age. 
        /// </summary>
        static void yourAge()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("You chose 2) - Tells your are by the year you were born");
            Console.WriteLine("Please state what year you were born");
            int yearBorn = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - yearBorn;
            if (age > 130)
            {
                Console.WriteLine((DateTime.Now.Year - yearBorn) + " years old huh?. I think your lying...");
            }
            else if (age < 100 && age > 70)
            {
                Console.WriteLine("You are " + (DateTime.Now.Year - yearBorn) + " years old... and soon dead.");
            }
            else
            {
                Console.WriteLine("You are " + (DateTime.Now.Year - yearBorn) + " years old.");
            }
        }
        static void tellJoke()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("You chose 3) - Only in it for the lolz");
            Console.WriteLine("Ye wanna hear a joke? Y / N");
            string answer = Console.ReadLine();
            if(answer == "Y")
            {
                Console.WriteLine(" ");
                Console.WriteLine("I mainly only program in C# and well I can never find any good jokes, about this language.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".");
                Console.WriteLine("Got it? Y / N:");
                string response = Console.ReadLine();
                if(response == "Y")
                {
                    Console.WriteLine("Your a genius!");
                }
                else {
                    Console.WriteLine("Not C# enough huh? Its ok, keep on compiling");
                }

            }
            else
            {
                Console.WriteLine("No? You must not be to sharp...");
            }
     
        }
        static void addOrMultiply()
        {
            int numbOne, numbTwo, choice, sum, product;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("You chose 3) - Only in it for the lolz");
            Console.WriteLine("Please provide a number:");
            numbOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide another number:");
            numbTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you. Please choose an operation:");
            Console.WriteLine("1) - Sum up the numbers:");
            Console.WriteLine("2) - Multiply the numbers:");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    sum = numbOne + numbTwo;
                    Console.WriteLine("The sum of " + numbOne + " and " + numbTwo + " is " + sum);
                    break;

                case 2:

                    product = numbOne * numbTwo;
                    Console.WriteLine("The the of " + numbOne + " and " + numbTwo + " is " + product);
                    break;
            }




        }

    }

}
