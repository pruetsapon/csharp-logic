using System;
using System.Linq;

namespace Logic.Model
{
    public class WaterBlock
    {
        public static int WaterBlockCalculator(int[] blocks)
        {
            var max = blocks.Max();
            var count = 0;
            for(int i = 0; i < blocks.Max(); i++)
            {
                var maxBlock = blocks.Where(b => b >= max);
                var fristIndex = Array.IndexOf(blocks, maxBlock.FirstOrDefault());
                var lastIndex = Array.LastIndexOf(blocks, maxBlock.LastOrDefault());
                var index = 0;
                foreach(var block in blocks)
                {
                    if(index > fristIndex && index < lastIndex && block < max)
                    {
                        count++;
                    }
                    index++;
                }
                max--;
            }
            return count;
        }
    }
}