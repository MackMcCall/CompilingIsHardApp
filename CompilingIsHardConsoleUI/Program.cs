using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompilingIsHardConsoleUI
{
    internal class Program
    {
        static int Main(string[] args)
        {
            int exitCode = 1;
            
            Console.WriteLine("Hello!");
            Console.WriteLine("Please give me a number");
            int userNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please give me another number");
            int secNumber = int.Parse(Console.ReadLine());
            double answer = userNumber / secNumber;
            Console.WriteLine($"{userNumber} / {secNumber} = {answer}");
            
            Console.WriteLine("Please give me your age!");
            int user_age = int.Parse(Console.ReadLine());
            if (user_age == 21)
            {
                Console.WriteLine("You may drink alcohol!");
            }
            
            Console.WriteLine("Give me the name of everyone that lives in your house separated by commas");
            string[] names = Console.ReadLine().Split('\u002C');
            List<Person> people = new List<Person>();
            foreach (string name in names)
            {
                Person p = new Person();
                p.Name = name;
                p.SayName();
                Console.WriteLine($"What is {name}'s date of birth?");
                p.Dob = DateTime.Parse(Console.ReadLine());
                people.Add(p);
            }
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            
            var something = DoSomething();
            
            Console.WriteLine("What is your favorite color?");
            switch (Console.ReadLine().ToLower())
            {
                case "red":
                    Console.WriteLine("Red is great!");
                    break;
                case "blue":
                    Console.WriteLine("Blue is awesome!");
                    break;
                case "yellow":
                    Console.WriteLine("Yellow reminds me of the sun");
                    break;
                case "orange":
                    Console.WriteLine("I like orange juice!");
                    break;
                default:
                    Console.WriteLine("Never heard of that color, what does it look like?");
                    break;
            }
            try
            {
                Random random = new Random();
                if (random.Next(1,100) % 2 == 0)
                {
                    throw new Exception();
                }
                else if (random.Next(1, 100) % 3 == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Console.WriteLine("The world is good");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return exitCode;
            }
            finally
            {
                Console.WriteLine("Henlooooo");
            }
            
            var somethingelse = DoSomethingElse();

            return exitCode;
        }

        private static int DoSomething()
        {
            Console.WriteLine("I am doing something!");
            return 15;
        }

        private static string DoSomethingElse()
        {
            return "I am doing something else!";
        }
        static void Garbage()
        {
            Console.WriteLine("Blah Blah Blah");
        }

    }
}
