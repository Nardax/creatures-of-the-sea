using creatures_of_the_sea;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace CreaturesOfTheSea
{
    class Program
    {
        public static object Creatures = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Moving Creatures!");
            MoveCreatures();
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
