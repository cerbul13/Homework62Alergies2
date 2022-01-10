using System;

namespace Homework62Alergies2
{
    public enum Alergies
    {
        eggs=0,
        peanuts=1,
        shellfish=2,
        strawberries=3,
        tomatoes=4,
        chocolate=5,
        pollen=6,
        cats=7
    }
    class Program
    {
        public static bool IsBitSet(int b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti score-ul lui Tom: ");
            int score = int.Parse(Console.ReadLine());
            for (int i=0;i<8;i++)
            {
                if (IsBitSet(score,i))
                {
                    Console.WriteLine($"Tom este alergic la {Enum.GetName(typeof(Alergies),i)}.");
                }
            }
        }
    }
}
