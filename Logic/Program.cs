using System;
using Logic.Model;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] blocks = { 1,0,3,1,0,1,2,0,1,2 };
            var countWater = WaterBlock.WaterBlockCalculator(blocks);
            Console.WriteLine("Water in block : " + countWater);
        }
    }
}
