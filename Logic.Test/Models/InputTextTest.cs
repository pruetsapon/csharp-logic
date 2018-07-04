using System;
using Xunit;
using Logic.Model;

namespace Logic.Model.Test
{
    public class InputTextTest
    {
        [Fact]
        public void InputTextTestCalculateNum()
        {
            string inputText = "az11w6ab";
            Assert.Equal(17, InputText.TextCalculator(inputText, false, true));
        }

        [Fact]
        public void InputTextTestCalculateText()
        {
            string inputText = "az11w6ab";
            Assert.Equal(53, InputText.TextCalculator(inputText, true, false));
        }

        [Fact]
        public void InputTextTestCalculateAll()
        {
            string inputText = "az11w6ab";
            Assert.Equal(70, InputText.TextCalculator(inputText, true, true));
        }

        [Fact]
        public void InputTextTestNoCalculate()
        {
            string inputText = "az11w6ab";
            Assert.Equal(0, InputText.TextCalculator(inputText, false, false));
        }
    }
}