using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpRandom
{
    internal class RandomGenerator
    {
        public string AskForHobby(string name)
        {
            Console.WriteLine($"Hello, {name}! This is your Chosen hobby:");
            Random rand = new Random();
            var randomNumber = rand.Next(0, 4);

            string hobby;

            if (randomNumber == 0)
            {
                hobby = $"{name} became a painter, you love painting birds in particular";
            }
            else if (randomNumber == 1)
            {
                hobby = $"Fish watcher, {name} enjoys watching fish swim around in ponds";
            }
            else if (randomNumber == 2)
            {
                hobby = $"{name} suddenly feels the urge to throw rocks around on a regular basis, big and small";
            }
            else if (randomNumber == 3)
            {
                hobby = $"The moon is calling {name}, you enjoy watching the sky at night";
            }
            else
            {
                hobby = $"Would you like to go again?";
            }

            return hobby;
        }
    }
}

