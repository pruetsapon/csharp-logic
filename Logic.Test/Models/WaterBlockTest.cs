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
            int[] blocks = { 1,0,3,1,1,0,2,1,2,0,1 };
            Assert.Equal(1, WaterBlock.WaterBlockCalculator(blocks, false));
        }
    }
}