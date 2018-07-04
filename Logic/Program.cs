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

            var inputText = "az/11w*-6a#!b";
            var countNumber = InputText.TextCalculator(inputText, true, true);
            Console.WriteLine("Count Number : " + countNumber);
        }
    }
}
