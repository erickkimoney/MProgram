using MyFirstProgram;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

internal class  Program
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

        //return keyword
        //double x;
        //double y;
        //double result;

        //Console.Write("Enter number 1: ");
        //x = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter number 2: ");
        //y = Convert.ToDouble(Console.ReadLine());

        //result = multiply(x, y);
        //Console.WriteLine($"Answer is {result}")

        //method overloading
        //double total;

        //total = multiply(2, 3, 10);
        //Console.WriteLine($"the answer is {total }");

        //params keyword
        /*  double total;
          total = Checkout(20, 30, 40);

          Console.WriteLine($"The total price is {total}");*/
        //try, catch finally
        /*double a;
        double b;
       
        double result;

        try
        {
            Console.Write("Enter number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number: ");
            b = Convert.ToDouble(Console.ReadLine());

            result = a / b;
            Console.WriteLine($"The answer is {result}");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Only accepts integers");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero IDIOT!!");
        }
        finally
        {
            Console.WriteLine("Thankyou for trying!!");
        }*/

        //conditional operator
        /* double temp = 3;
         String message;


             Console.WriteLine(message = (temp >= 15) ? "it's warm outside" : "it's cold outside");*/

        //string interpolation
        /* String name= "Bruce Locker";
         int age = 34;
         *//* Console.WriteLine("Hello " + name);
          Console.WriteLine("You are " + age + " years old");*//*
         Console.WriteLine($"Hello {name} You are {age} years old!");
 */
        //Messages.Hello();

        //objects

        //inheritance
        //abstract modifier -  to indicate that a class is incomplete and cannnot instantiate objects


        /*        car car = new car();
                bicycle bicycle = new bicycle();
                boat boat = new boat();
                vehicle vehicle1 = new vehicle();

                Console.WriteLine(car.speed);
                Console.WriteLine(car.wheel);
                car.go();

                Console.WriteLine(bicycle.speed);
                Console.WriteLine(bicycle.wheel);
                bicycle.go();

                Console.WriteLine(boat.speed);
                Console.WriteLine(boat.wheel);
                boat.go();
        */

        //array of objects

        /*        car[] garage = new car[3];

                car car1 = new car("Mustang");
                car car2 = new car("Chevrolette");
                car car3 = new car("Subaru");

                garage[0] = car1;
                garage[1] = car2;
                garage[2] = car3;

                foreach(car car in garage)
                {
                    Console.WriteLine(car.model);
                }

                Console.WriteLine(garage[0].model);
                Console.WriteLine(garage[1].model);
                Console.WriteLine(garage[2].model);*/
        //object as arugument
        /* Car car1 = new Car("Toyota", "Red");
         Car car2 = Copy(car1);

         Console.WriteLine($"{car1.color} {car1.model}");
         Console.WriteLine($"{car2.color} {car2.model}");*/

        //method overriding
        /* Dog dog1 = new Dog();
         Cat cat1 = new Cat();

         dog1.Speak();
         cat1.Speak();

 */      //ToString() - convert a method to string representation

        /* Car car1 = new Car("Toyota", "Corolla", 2011, "Blue");

         Console.WriteLine(car1.ToString());*/

        //polymorphism - objects can be identified by more than one type

        /*Car car1 = new Car();
        Bicycle bicycle1 = new Bicycle();
        Boat boat1 = new Boat();

        Vehicle[] vehicles = {car1,  bicycle1, boat1};

        foreach(Vehicle vehicle in vehicles)
        {
            vehicle.Go();
        }*/

        //interface - defines a contract that all classes inheriting should follow

        /*Rabbit rabbit1 = new Rabbit();
        Hawk hawk1 = new Hawk();
        Fish fish1 = new Fish();

        rabbit1.Flee();
        hawk1.Hunt();
        fish1.Flee();
        fish1.Hunt();*/

        //Lists - represents a lisst of objects that can be accessd by index,  can increase or decrease dynamically

        List<String> food = new List<String>();

        food.Add("pizza");
        food.Add("bread");
        food.Add("tomato");
        food.Add("ham");
        food.Add("fish");
        food.Add("cake");

        //food.Remove("ham");
        /*  food.Insert(0, "sushi");

          Console.WriteLine(food.Count);*/
        //Console.WriteLine(food.LastIndexOf("cake"));
        //Console.WriteLine(food.Contains("taco"));
        //food.Sort();
        food.Reverse();
        food.Clear();


        foreach (String item in food)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

    /*interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away");
        }
    }
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food");
        }
    }
    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is seearching for food");
        }
    }*/


    /*class Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }   
    }*/

    /*class Car
    {
        String make;
        public String model;
        int year;
        String color;
        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            return $"This car is {make} {model} {year} {color} in color";
        }
    }*/

    /*class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes ''goes brrr''");
        }
    }
    class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes '' woof'");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes ''meeoow''");
        }
    }*/
    /* public static Car Copy(Car car)
      {
          return new Car(car.model, car.color);
      }

      public class Car
      {
          public String model;
          public String color;

          public Car(String model, String color)
          {
              this.model = model;
              this.color = color;
          }
      }*/

    /*abstract class vehicle
    {
        public int speed = 0;
         
        public void go ()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }
    class car :vehicle
    {
        public int wheel = 4;
        int maxspeed = 400;
    }
    class bicycle : vehicle
    {
        public int wheel = 2;
        int maxspeed = 200;
    }
    class boat : vehicle
    {
        public int wheel = 0;
        int maxspeed = 100;
    }*/

    /*class Car()
    {
        String make;
        String model;
        int year;
        String color;
        
        public Car()
        { 
        
        }
    }*/


    //static double Checkout(params double[] prices)
    //{
    //    double total = 0;
    //    foreach (double price in prices)
    //    {
    //        total = total + price;
    //    }
    //    return total;
    //}

    /*static double multiply(double x, double y)
    {
        return x * y;

    }*/
    //static double multiply (double x, double y, double z)
    //{
    //    return x * y * z;
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

