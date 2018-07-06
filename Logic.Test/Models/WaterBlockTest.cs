using System;
using Xunit;
using Logic.Model;

namespace Logic.Model.Test
{
    public class WaterBlockTest
    {
        [Fact]
        public void WaterBlockTestHasFloor()
        {
            int[] blocks = { 1,0,3,1,1,0,2,1,2,0,1 };
            Assert.Equal(7, WaterBlock.WaterBlockCalculator(blocks, true));
        }

        [Fact]
        public void WaterBlockTestNoFloor()
        {
            int[] blocks0 = { 1,2,3,4,5,6,5,4,3,2,1 };
            Assert.Equal(0, WaterBlock.WaterBlockCalculator(blocks0, false));
            int[] blocks1 = { 1,0,3,1,1,0,2,1,2,0,1 };
            Assert.Equal(1, WaterBlock.WaterBlockCalculator(blocks1, false));
            int[] blocks2 = { 1,0,3,1,1,0,2,1,2,1,2 };
            Assert.Equal(2, WaterBlock.WaterBlockCalculator(blocks2, false));
            int[] blocks3 = { 2,1,3,1,1,0,2,1,2,1,1 };
            Assert.Equal(2, WaterBlock.WaterBlockCalculator(blocks3, false));
            int[] blocks4 = { 0,1,3,1,1,0,2,1,2,1,0 };
            Assert.Equal(1, WaterBlock.WaterBlockCalculator(blocks4, false));
            int[] blocks6 = { 1,0,3,4,5,0,5,4,3,0,1 };
            Assert.Equal(0, WaterBlock.WaterBlockCalculator(blocks6, false));
        }
    }
}