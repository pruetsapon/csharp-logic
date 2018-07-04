using System;
using System.Linq;
using System.Collections.Generic;

namespace Logic.Model
{
    public class WaterBlock
    {
        public static int WaterBlockCalculator(int[] blocks, bool hasFloor)
        {
            if(hasFloor)
            {
                return CalculatorHasFloor(blocks);
            }
            else
            {
                return CalculatorNoFloor(blocks);
            }
        }

        private static int CalculatorNoFloor(int[] blocks)
        {
            var count = 0;
            var maxHeight = blocks.Max();
            for(int i = 0; i < blocks.Max(); i++)
            {
                var maxBlocks = blocks.Where(b => b >= maxHeight);
                var newBlocks = Enumerable.Range(0, blocks.Length).ToDictionary(x => x, x => blocks[x]);
                var index = 0;
                foreach(var block in blocks)
                {
                    if(block != 0)
                    {
                        var fristZeroIndex = newBlocks.Where(b => b.Key < index && b.Value == 0).LastOrDefault().Key;
                        var lastZeroIndex = newBlocks.Where(b => b.Key > index && b.Value == 0).FirstOrDefault().Key;
                        if(fristZeroIndex != 0 && lastZeroIndex != 0)
                        {
                            var fristObj = newBlocks.SingleOrDefault(b => b.Key == (fristZeroIndex + 1));
                            var lastObj = newBlocks.SingleOrDefault(b => b.Key == (lastZeroIndex - 1));
                            if(index > fristObj.Key && index < lastObj.Key && fristObj.Value >= maxHeight && lastObj.Value >= maxHeight && block < maxHeight)
                            {
                                count++;
                            }
                        }
                    }
                    index++;
                }
                maxHeight--;
            }
            return count;
        }

        private static int CalculatorHasFloor(int[] blocks)
        {
            var count = 0;
            var maxHeight = blocks.Max();
            for(int i = 0; i < blocks.Max(); i++)
            {
                var maxBlocks = blocks.Where(b => b >= maxHeight);
                var fristIndex = Array.IndexOf(blocks, maxBlocks.FirstOrDefault());
                var lastIndex = Array.LastIndexOf(blocks, maxBlocks.LastOrDefault());
                var index = 0;
                foreach(var block in blocks)
                {
                    if(index > fristIndex && index < lastIndex && block < maxHeight)
                    {
                        count++;
                    }
                    index++;
                }
                maxHeight--;
            }
            return count;
        }
    }
}