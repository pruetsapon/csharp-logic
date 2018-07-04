using System;
using Xunit;
using Logic.Model;

namespace Logic.Model.Test
{
    public class WaterBlockTest
    {
        [Fact]
        public void WaterBlockTestPassed()
        {
            int[] blocks = { 1,0,3,1,0,1,2,0,1,2 };
            Assert.Equal(8, WaterBlock.WaterBlockCalculator(blocks));
        }
    }
}