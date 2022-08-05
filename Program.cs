using System;

// NameSpace
namespace Guest_Number
{
    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            // Run GetAppInfo function to get info
            GetAppInfo();

            //Ask for users name and greet
            GreetUser();

            while (true) {
                // Set Correct number

                //int correctNumber = 7;
                // Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going
                        continue;

                    }


                    // Cast to int and put guess
                    guess = Int32.Parse(input);


                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");

                    }
                }

              
                // Print success message
                PrintColorMessage(ConsoleColor.Yellow,"You are CORRECT!!!!!!!!!!!!!!");

                // Ask to plat again
                Console.WriteLine("Play Again ? [Y or N]");

                //Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else {
                    return;
                }
            }
        }

        //Get App and Display App info
        static void GetAppInfo() {
            //Set app vars
            string appName = "Guest the Number";
            string appVersion = "1.0.0";
            string appAuthor = "Martin Fernandez";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        // Ask User name and Greet
        static void GreetUser() {
            //Ask users name
            Console.WriteLine("What is your name?");
            //Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game....", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = ConsoleColor.Red;

            // Tell user its not a number
            Console.WriteLine("Please enter a actual number");

            //Reset text color
            Console.ResetColor();
        }
    }
}
