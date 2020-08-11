using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            app_info();

            user_input();

            while (true)
            {
                int guess_number = -1;

                Random random = new Random();
                int correct_number = random.Next(1, 20);

                Console.WriteLine("Guess a number between 1 and 20...");

                while (guess_number != correct_number)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess_number))
                    {
                        app_colors(ConsoleColor.Red, "Please enter a number...");
                        continue;
                    }

                    guess_number = Int32.Parse(input);

                    if (guess_number != correct_number)
                    {
                        app_colors(ConsoleColor.Red, "Wrong number. Please try again...");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("CORRECT!!!");

                Console.ResetColor();

                Console.WriteLine("Play again? [Y or N]");
                string ans = Console.ReadLine().ToUpper();

                if (ans == "Y")
                {
                    continue;
                }
                else if(ans == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void user_input()
        {
            Console.WriteLine("What's your name?");

            string input_name = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play the game...", input_name);
        }

        static void app_info()
        {
            string my_app = "Number Guesser";

            string username = "Andreas";

            Console.WriteLine(username + " " + my_app);
        }

        static void app_colors(ConsoleColor color, string msg)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(msg);

            Console.ResetColor();
        }
    }
}
