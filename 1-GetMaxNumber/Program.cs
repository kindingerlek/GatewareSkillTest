
using System;
using System.Linq;

namespace GatewaySkillTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetRandomArray(from: 0, to: 100, size: 10);

            Console.WriteLine($"arr: [{string.Join(", ", arr)}]\nmax: {GetMaxNumber(arr)}");
        }

        private static int[] GetRandomArray(int from, int to, int size)
        {
            var rand = new Random();
            return Enumerable.Repeat(0, size).Select(i => rand.Next(from, to)).ToArray();
        }

        private static int GetMaxNumber(int[] arr)
        {
            return arr.Max();
        }
    }
}
