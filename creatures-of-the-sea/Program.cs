using creatures_of_the_sea;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace CreaturesOfTheSea
{
    class Program
    {
        public static string[,] Creatures;

        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Creatures!");
            InializeCreatures();

            Console.WriteLine("Moving Creatures!");
            MoveCreatures();
        }

        private static void InializeCreatures()
        {
            Creatures = new string[10, 10];
            Creatures[2, 7] = "C";
            Creatures[5, 1] = "F";
            Creatures[9, 0] = "S";
        }

        public static void MoveCreatures()
        {
        }

        public static Direction GetRandomDirection()
        {
            var random = new Random(DateTime.Now.Millisecond);
            var randomValue = random.Next(0, 4);
            return (Direction)randomValue;
        }
    }
}
