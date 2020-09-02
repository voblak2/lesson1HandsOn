using System;

namespace lesson1HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = false;

            var wear = "Wear sunglasses.";
            var dontWear = "You don't need to wear sunglasses.";

                if (isSunny)
                {
                    Console.WriteLine(wear);
                }   else 
                    {
                        Console.WriteLine(dontWear);
                    }

            bool atBeach = true;

            var sunblock = "Sunblock is a good idea.";
            var noSunblock = "Sunblock isn't needed.";

            if (isSunny) 
            {
                if (atBeach)
                {
                    Console.WriteLine(sunblock);
                }   else 
                    {
                        Console.WriteLine(noSunblock);
                    }
            }
            bool goAnyway = true;

            var going = "Awesome! Glad you don't mind clouds!";
            var nextTime = "No worries! Hopefully next time we will have some sun!";

                if (goAnyway) 
                {
                    Console.WriteLine(going);
                }   else 
                    {
                        Console.WriteLine(nextTime);
                    }
        }
    }
}
