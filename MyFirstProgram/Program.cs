using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        //Find the hypotenuse
        //Console.WriteLine("Enter Triangle side A: ");
        //double a = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Enter Triangle side B: ");
        //double b = Convert.ToDouble(Console.ReadLine());

        //double c = Math.Sqrt((a * a) + (b * b));
        //Console.WriteLine("The hypotenuse of this triangle is: " + c);

        //String methods
        //String fullName = "Bro Code";
        //String phoneNumber = "123-456-7890";

        //Console.WriteLine(fullName);
        //fullName = fullName.ToUpper();
        //Console.WriteLine(fullName);
        //fullName = fullName.ToLower();
        //Console.WriteLine(fullName);
        //phoneNumber = phoneNumber.Replace("-", "/");
        //Console.WriteLine(phoneNumber);
        //String userName = fullName.Insert(0, "Mr. ");
        //Console.WriteLine(userName);

        //String firstName = fullName.Substring(0, 4);
        //Console.WriteLine(firstName);

        //if statements
        //Console.WriteLine("What is your age: ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //if (age > 100)
        //{
        //    Console.WriteLine("You are old");
        //}
        //else if (age > 18)
        //{
        //    Console.WriteLine("You are an adult");
        //}
        //else
        //{
        //    Console.WriteLine("You are a minor");
        //}
        //Console.WriteLine("What is your name");
        //String name = Console.ReadLine();
        //if (name == "")
        //{
        //    Console.WriteLine("You havent entered your name!");
        //}
        //else
        //{
        //    Console.WriteLine("Your name is " + name);
        //}

        //switch statements
        //Console.WriteLine("What day is it today?");
        //String day = Console.ReadLine();

        //switch (day)
        //{
        //    case "Monday":
        //        Console.WriteLine("Its Monday");
        //        break;
        //    case "Tuesday":
        //        Console.WriteLine("Its Tuesday");
        //        break;
        //    case "Wednesday":
        //        Console.WriteLine("Its Wednesday");
        //        break;
        //    case "Thursday":
        //        Console.WriteLine("Its Thursday");
        //        break;
        //    case "Friday":
        //        Console.WriteLine("Its Friday");
        //        break;
        //    case "Saturday":
        //        Console.WriteLine("Its Saturday");
        //        break;
        //    case "Sunday":
        //        Console.WriteLine("Its Sunday");
        //        break;
        //    default:
        //        Console.WriteLine(day + " is not a day");
        //        break;

        //Logical operators
        //Console.WriteLine("What is the temperature outside");
        //double temp = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Temperature is " + temp);
        //if (temp >= 10 && temp <= 50)
        //{
        //    Console.WriteLine("It is warm outside");
        //}
        //else if (temp <= -50 || temp >= 50) ;
        //{
        //    Console.WriteLine("Do not go outside");
        //}

        //while loop
        //Console.Write("Enter your name: ");
        //String name = "";

        //while (name == "")
        //{
        //    Console.Write("Enter your name ");
        //    name = Console.ReadLine();
        //}

        //Console.WriteLine("Hello " +name);

        //for loop

        //for(int i = 1; i<10; i+=2)
        //{
        //    Console.WriteLine(i);
        //}
        //for (int i= 10; i>0; i--)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("Happy new year");

        //nested loops
        //Console.WriteLine("How many rows");
        //int rows = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("How many columns");
        //int columns = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("What symbol");
        //String symbol = Console.ReadLine();
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < columns; j++)
        //    {
        //        Console.WriteLine(symbol);
        //    }
        //    Console.WriteLine();
        //}

        //number guessing game
        //Random random = new Random();
        //bool playagain = true;
        //int min = 1;
        //int max = 100;
        //int guess;
        //int number;
        //int guesses;
        //String response;

        //while (playagain)
        //{
        //    guess = 0;
        //    guesses = 0;
        //    response = "";
        //    number = random.Next(min, max + 1);

        //    while (guess != number)
        //    {
        //        Console.WriteLine("Guess a number between" + max + "-" + min + ":");
        //        guess = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Guess: " + guess);
        //         if (guess > number)
        //        {
        //            Console.WriteLine(guess + " is too high");
        //        }
        //         else if (guess < number)
        //                { 
        //            Console.WriteLine(guess + " is too low"); 
        //        }

        //        guesses += 1;
        //    }
        //    Console.WriteLine("Number: " + number);
        //    Console.WriteLine("YOU WIN!!");
        //    Console.WriteLine("Guesses" + guesses);
        //    Console.WriteLine("Would you like to play again (Y/N): ");
        //    response = Console.ReadLine();
        //    response = response.ToUpper();
        //     if (response == "Y")
        //    {
        //        playagain = true;
        //    }
        //    else
        //    {
        //        playagain = false;
        //    }
        //}
        //Console.WriteLine("Thanks for playing!");
        //Console.ReadKey();

        //Rock, Paper, Scissors
        Random random = new Random();
        bool playagain = true;
        String player;
        String computer;
        String anothergame;

        while (playagain)
        {
            player = "";
            computer = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.Write("Choose ROCK, PAPER, SCISSORS:");
                player = Console.ReadLine();
                player = player.ToUpper();
            }

            switch (random.Next(0, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }
            Console.WriteLine("Player " + player);
            Console.WriteLine("Computer " + computer);

            switch (player)
            {
                case "ROCK":
                    if ( computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if ( computer == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }

                    break;
                case "SCISSORS":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }

                    break;
            }
            Console.WriteLine("Would you like to play again Y/N: ");
            anothergame = Console.ReadLine();
            anothergame = anothergame.ToUpper();
            if (anothergame == "Y")
            {
                playagain = true;
            }
            else
            {
                playagain = false;
            }

            Console.WriteLine("Thankyou for playing!");
        }
        
        Console.ReadKey();

    }

    
}