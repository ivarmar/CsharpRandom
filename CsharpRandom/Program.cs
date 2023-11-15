using System;

namespace CsharpRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator hobbyInstance = new RandomGenerator();

            while (true)
            {
                Console.WriteLine("Enter your name for a hobby (or type 'exit' to end):");
                var name = Console.ReadLine();

                if (name.ToLower() == "exit")
                {
                    break;
                }


                var hobby = hobbyInstance.AskForHobby(name);
                Console.WriteLine(hobby);
            }
        }
    }
}

