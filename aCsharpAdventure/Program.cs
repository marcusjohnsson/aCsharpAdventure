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
                Console.WriteLine("[1] - An example of a while loop");
                Console.WriteLine("[2] - Tells your age by the year you were born");
                Console.WriteLine("[3] - Only in it for the lolz");
                Console.WriteLine("[4] - Add or Muliply?");
                Console.WriteLine("[5] - Crash & Burn");
                Console.WriteLine("[6] - Guessing Game");
                Console.WriteLine("Type EXIT to close the application");

                string opt = Console.ReadLine();

                // Exit app
                if(opt == "EXIT")
                {
                    exit = true;
                }

                // Error handling wrong options. 
                bool choice = Int32.TryParse(opt, out int menuOption);
                if (!choice)
                {
                    Console.WriteLine("Thats not a valid option");
                }
                    

                switch (menuOption)
                {
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

                    case 5:

                        crashAndBurn();
                        break;

                    case 6:

                        guessingGame();
                        break;

                    default:

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
            Console.WriteLine("Give me a whole number and I will count to it:");

            int i;
            int myNumber = int.Parse(Console.ReadLine());

            i = 0;
            while (i <= myNumber)
            {
                Console.WriteLine(i);
                i += 1;

            }

            Console.WriteLine("Done! Hot dang that be some fast counting...");
            Console.WriteLine("Ye want me to do it again but slower? Y / N");
            string answer = Console.ReadLine();
            
            if (answer == "Y")
            {
                int milliSecs = 100;
                Console.WriteLine("Ok! Here we go!");
                i = 0;
                while (i <= myNumber)
                {
                    System.Threading.Thread.Sleep(milliSecs);
                    Console.WriteLine(i);
                    i += 1;

                }
                float secs = (milliSecs * myNumber) / 1000;
                Console.WriteLine("Done, thats 0 to " + myNumber + " in " + secs + " seconds.");
            }
            else
            {
                System.Threading.Thread.Sleep(200);
                Console.WriteLine(".... ok, well, whatever.");
            }
        }
        /// <summary>
        /// Prompts for the age of the user. Calculates age. 
        /// </summary>
        static void yourAge()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Please state what year you were born");
            int yearBorn = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - yearBorn;

            if(age < 0)
            {
                int yearsIntoFuture = yearBorn - DateTime.Now.Year;
                Console.Write("Wooooow! You are from " + yearsIntoFuture + " years into the frikkin future!");
                Console.Write(" "); // line break bug
            }
            else
            {
                    if (age > 125)
                    {
                        Console.WriteLine("So you are " + (DateTime.Now.Year - yearBorn) + " years old huh?. Im a computer, not a fool.");
                        Console.WriteLine("One more time, truthfully.");
                        yourAge(); // Recursive function call to get the truth!
                    }
                    else if (age <= 120 && age > 70)
                    {
                        Console.WriteLine("You are " + (DateTime.Now.Year - yearBorn) + " years old...");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine(".. and soon dead.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("=(");
                        System.Threading.Thread.Sleep(3000);

                    }
                    else
                    {
                        Console.WriteLine("You are " + (DateTime.Now.Year - yearBorn) + " years old.");
                    }
                }

        }
        static void tellJoke()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Ye wanna hear a joke? Y / N");
            string v = Console.ReadLine();
            string answer = v;
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
        static void crashAndBurn()
        {
            // Example of TryParse(String, Int32)
            Console.WriteLine("Examples of error handling.");
            Console.WriteLine("Lets start with TryParse()");
            Console.WriteLine("We will try :Int32.TryParse(Console.ReadLine(), out int number)");
            Console.WriteLine("It attempts to parse a string to a number, if it fails it will ouput the variable number set to 0"); ;
            Int32.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine("number = " + number);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("-------------------------------------");

            // Example of TryCatch clause)
            Console.WriteLine("Now, Lets check out the TryCatch Clause by attempting to divide an int by 0");
            int numb = 0;
            try
            {
                numb /= 0;
            }
            catch (Exception error)
            {
                Console.WriteLine("It excecutes the operation numb /= 0 in try, fails and get caught by catch that throws the error.");
                Console.WriteLine(error);
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("-------------------------------------");
            // Example of TryParse() assigned as a boolean and then evaluated
            Console.WriteLine("TryParse can be used as an conversion and exception");
            Console.WriteLine("Consider the following code:");
            Console.WriteLine("int zero = 0;");
            Console.WriteLine("bool success = Int32.TryParse(Console.ReadLine(), out zero);");
            Console.WriteLine("if (!success) {");
            Console.WriteLine(" ... some output");
            Console.WriteLine("}");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Please input a string to see it in action.");
            int zero = 0;
            bool success = Int32.TryParse(Console.ReadLine(), out zero);
            if (!success) {
                Console.WriteLine("The variable success is false and this very message is the output");
            }
            else
            {
                Console.WriteLine("Idiot, I said STRING....");
            }
            Console.WriteLine("-------------------------------------");
        }
        static void guessingGame()
        {
            int randomNumber;
            Random newRandom = new Random();
            randomNumber = newRandom.Next(1, 21); // declared two times? 
            bool isRunning = true;
            Console.WriteLine("Guess a number between 1 and 20");
            int guess = Convert.ToInt32(Console.ReadLine());
            while (isRunning) // ! 
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("To hiiiiigh mofo! Guess again!");
                    guess = Convert.ToInt32(Console.ReadLine()); // guess never changes causing infinity loop
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("To loOow! Guess again!");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess == randomNumber) // assigning = is wrong. == is the correct operator
                { // no codeblock
                    Console.WriteLine("Right on the number! You guessed correct! Bye!");
                    isRunning = false;
                }
            }
        }

    }

}
