using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Logic.Model;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the choice : [1-2]");
            Console.WriteLine("1. InputText");
            Console.WriteLine("2. WaterBlock");

            var choice = Console.ReadLine();
            switch(Int32.Parse(choice))
            {
                case 1:
                    Console.WriteLine("Please input text.");
                    var inputText = Console.ReadLine();
                    var countNumber = InputText.TextCalculator(inputText, true, true);
                    Console.WriteLine("Count Number : " + countNumber);
                    break;
                case 2:
                    var regex = new Regex(@"[\d]");
                    Console.WriteLine("Please input number.");
                    var blocks = new List<int>();
                    do {
                        var input = Console.ReadLine();
                        blocks.Add(regex.IsMatch(input) == false ? 0 : Int32.Parse(input));
                    } while(blocks.Count < 5);
                    var countWater = WaterBlock.WaterBlockCalculator(blocks.ToArray());
                    Console.WriteLine("Water in block : " + countWater);
                    break;
                default:
                    Console.WriteLine("Please input [1-2]");
                    break;
            }
        }
    }
}
