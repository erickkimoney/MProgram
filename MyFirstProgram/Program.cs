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
        //Random random = new Random();
        //bool playagain = true;
        //String player;
        //String computer;
        //String anothergame;

        //while (playagain)
        //{
        //    player = "";
        //    computer = "";
        //    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
        //    {
        //        Console.Write("Choose ROCK, PAPER, SCISSORS:");
        //        player = Console.ReadLine();
        //        player = player.ToUpper();
        //    }

        //    switch (random.Next(0, 4))
        //    {
        //        case 1:
        //            computer = "ROCK";
        //            break;
        //        case 2:
        //            computer = "PAPER";
        //            break;
        //        case 3:
        //            computer = "SCISSORS";
        //            break;
        //    }
        //    Console.WriteLine("Player " + player);
        //    Console.WriteLine("Computer " + computer);

        //    switch (player)
        //    {
        //        case "ROCK":
        //            if ( computer == "ROCK")
        //            {
        //                Console.WriteLine("It's a draw!");
        //            }
        //            else if ( computer == "PAPER")
        //            {
        //                Console.WriteLine("You lose!");
        //            }
        //            else
        //            {
        //                Console.WriteLine("You win!");
        //            }
        //            break;
        //        case "PAPER":
        //            if (computer == "ROCK")
        //            {
        //                Console.WriteLine("You win!");
        //            }
        //            else if (computer == "PAPER")
        //            {
        //                Console.WriteLine("It's a draw!");
        //            }
        //            else
        //            {
        //                Console.WriteLine("You lose!");
        //            }

        //            break;
        //        case "SCISSORS":
        //            if (computer == "ROCK")
        //            {
        //                Console.WriteLine("You lose!");
        //            }
        //            else if (computer == "PAPER")
        //            {
        //                Console.WriteLine("You win!");
        //            }
        //            else
        //            {
        //                Console.WriteLine("It's a draw!");
        //            }

        //            break;
        //    }
        //    Console.WriteLine("Would you like to play again Y/N: ");
        //    anothergame = Console.ReadLine();
        //    anothergame = anothergame.ToUpper();
        //    if (anothergame == "Y")
        //    {
        //        playagain = true;
        //    }
        //    else
        //    {
        //        playagain = false;
        //    }

        //    Console.WriteLine("Thankyou for playing!");
        //}

        //Console.ReadKey();

        //dice roll
        //Console.WriteLine("---------------");
        //Console.WriteLine("Roll the dice");
        //Console.WriteLine("---------------");

        //Random random = new Random();
        //String roll_dice;
        //int min = 1;
        //int max = 6;
        //bool playagain = true;
        //String response;

        //while (playagain)
        //{
        //    switch (random.Next(min, max + 1))
        //    {
        //        case 1:
        //            Console.WriteLine("1");
        //            break;
        //        case 2:
        //            Console.WriteLine("2");
        //            break;
        //        case 3:
        //            Console.WriteLine("3");
        //            break;
        //        case 4:
        //            Console.WriteLine("4");
        //            break;
        //        case 5:
        //            Console.WriteLine("5");
        //            break;
        //        case 6:
        //            Console.WriteLine("6");
        //            break;
        //    }
        //    Console.WriteLine("Play again Y/N? ");
        //    response = Console.ReadLine();
        //    response = response.ToUpper();
        //    if (response == "Y")
        //    {
        //        playagain = true;
        //    }
        //    else
        //    {
        //        playagain = false;
        //    }
        //}

        //calculator program
        //do
        //{
        //    Console.WriteLine("------------------");
        //    Console.WriteLine("Calculator Program");
        //    Console.WriteLine("------------------");

        //    double num_1 = 0;
        //    double num_2 = 0;
        //    double result = 0;

        //    Console.Write("Enter number 1: ");
        //    num_1 = Convert.ToDouble(Console.ReadLine());

        //    Console.Write("Enter number 2: ");
        //    num_2 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("\tChoose operator");
        //    Console.WriteLine("\t+ for addition");
        //    Console.WriteLine("\t- for subtraction");
        //    Console.WriteLine("\t* for multiplication");
        //    Console.WriteLine("\t/ for division");
        //    Console.Write("Choose an option: ");
        //    switch (Console.ReadLine())
        //    {
        //        case "+":
        //            result = num_1 + num_2;
        //            Console.WriteLine($"result of {num_1} + {num_2} = " + result);
        //            break;
        //        case "-":
        //            result = num_1 - num_2;
        //            Console.WriteLine($"result of {num_1} - {num_2} = " + result);
        //            break;
        //        case "*":
        //            result = num_1 * num_2;
        //            Console.WriteLine($"result of {num_1} * {num_2} = " + result);
        //            break;
        //        case "/":
        //            result = num_1 / num_2;
        //            Console.WriteLine($"result of {num_1} / {num_2} = " + result);
        //            break;
        //    }
        //    Console.WriteLine("Would you like to calculate again Y = Yes N = No");
        //} while (Console.ReadLine().ToUpper() == "Y");

        //array
        //String[] house = new string[5];
        ////String[] house = ["chair", "table", "sofa", "bulb", "books"];
        //house[0] = "chair";
        //house[1] = "table";
        //house[2] = "sofa";
        //house[3] = "bulb";
        //house[4] = "books";
        ////Console.WriteLine(house[0]);
        ////Console.WriteLine(house[1]);
        ////Console.WriteLine(house[2]);
        //house[0] = "bulb";
        //for (int i = 0; i < house.Length; i++)
        //{
        //    Console.WriteLine(house[i]);
        //}

        //foreach loop
        //String[] house = ["chair", "table", "sofa", "bulb", "books"];
        //foreach(String item in house)
        //{
        //    Console.WriteLine(item);
        //}
       
    //    //methods
    //    int age = 21;
    //    String name = "Erick";
    //    String last_name = "Kimani";
    //    singHappyBirthday(age, name, last_name);
    //    singHappyBirthday(age, name, last_name);
    //    singHappyBirthday(age, name, last_name);
    //}







    //static void singHappyBirthday(int age, String name, String last_name)
    //{
    //    Console.WriteLine("Happy birthday to you!");
    //    Console.WriteLine("Happy birthday to you!");
    //    Console.WriteLine($"Happy birthday dear {name}!");
    //    Console.WriteLine($"Happy birthday dear {last_name}!");
    //    Console.WriteLine($"You are {age} years old now");
    //}
}