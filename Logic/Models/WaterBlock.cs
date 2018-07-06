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
                var newBlocks = Enumerable.Range(0, blocks.Length).ToDictionary(x => x, x => blocks[x]);
                var maxBlocks = newBlocks.Where(b => b.Value >= maxHeight);
                var index = 0;
                foreach(var block in blocks)
                {
                    if(block != 0)
                    {
                        var fristZeroIndex = newBlocks.Where(b => b.Key < index && b.Value == 0).LastOrDefault().Key;
                        var fristMaxBlocks = maxBlocks;
                        if(fristZeroIndex != 0)
                        {
                            fristMaxBlocks = fristMaxBlocks.Where(b => b.Key > fristZeroIndex);
                        }
                        var fristIndex = Array.IndexOf(blocks, fristMaxBlocks.FirstOrDefault().Value);
                        var lastZeroIndex = newBlocks.Where(b => b.Key > index && b.Value == 0).FirstOrDefault().Key;
                        var lastMaxBlocks = maxBlocks;
                        if(lastZeroIndex != 0)
                        {
                            lastMaxBlocks = lastMaxBlocks.Where(b => b.Key < lastZeroIndex);
                        }
                        var lastIndex = Array.LastIndexOf(blocks, lastMaxBlocks.LastOrDefault().Value);
                        var fristObj = newBlocks.SingleOrDefault(b => b.Key == fristIndex);
                        var lastObj = newBlocks.SingleOrDefault(b => b.Key == lastIndex);
                        if(index > fristObj.Key && index < lastObj.Key && fristObj.Value >= maxHeight && lastObj.Value >= maxHeight && block < maxHeight)
                        {
                            count++;
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