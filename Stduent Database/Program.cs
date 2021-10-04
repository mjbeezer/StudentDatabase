using System;

namespace Stduent_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring all strings
            string[] student = { "Justin", "Matt", "Logan", "Raston", "Yousif", "Yash", "Chris", "Radeen", "Joshua", "Aron", "Kasean", "Scott", "Delmar", "Brandon" };
            string[] town = { "Wyoming, MI", "Flint, MI", "Plymouth, MI", "Zeeland, MI", "Oak Park, MI", "Detroit, MI", "Novi, MI", "Warren, MI", "Northville", "Berea, KY", "Detroit, MI", "Lansing, MI", "Detroit, MI", "Novi, MI" };
            string[] food = { "Baja Blast", "Hot Wings", "Funyons", "Vanilla Instant Pudding", "Deep Dish Pizza", "Hot Cheeto Puffs", "Tacos", "Mexican", "Nalesniki", "Sushi", "Steak", "Nashville Chicken", "Vietnamese", "Sushi" };

            Console.WriteLine("Welcome to our C# Class!");
            bool program = true;
            bool keepGoing = true;
            int choice;
            do
            {
                while (true)
                {
                    Console.WriteLine("Which student would you like to learn more about? Please enter a number, 0 through 14.");
                    choice = int.Parse(Console.ReadLine().Trim());
                    if (choice > 14 || choice < 0)
                    {
                        Console.WriteLine("That student does not exist. Please enter a number, 0 through 14.");
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 0; i < student.Length; i++)
                {
                        if (i == choice)
                        {

                            while (keepGoing)
                            {
                                Console.WriteLine($"Student {choice} is {student[choice]}. Would you like to know their hometown or favorite food?");
                                string question1 = Console.ReadLine().Trim().ToLower();
                                if (question1 == "hometown")
                                {
                                    Console.WriteLine($"Their hometown is {town[choice]}.");
                                    break;
                                }
                                else if (question1 == "favorite food")
                                {
                                    Console.WriteLine($"Their favorite food is {food[choice]}.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("That information is not available. Please enter hometown or favorite food.");
                                }

                            }
                            Console.WriteLine("Would you like to learn about another student? y/n");
                            string anotherStud = Console.ReadLine().Trim().ToLower();
                            if (anotherStud == "n")
                            {
                                program = false;
                            }
                            else
                            {
                                break;
                            }
                        }
                }            
            } while (program);
        }
    }
}

