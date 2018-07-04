using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Logic.Model
{
    public class InputText
    {
        public static int TextCalculator(string inputText, bool calText, bool calNum)
        {
            var total = 0;
            if(calText || calNum)
            {
                inputText = Regex.Replace(inputText, "[^0-9a-zA-Z]+", "");
                if(calText)
                {
                    var endlishStr = "abcdefghijklmnopqrstuvwxyz";
                    var texts = inputText.ToLower().ToCharArray();
                    total += texts.Sum(s => endlishStr.Contains(s) == true ? endlishStr.IndexOf(s) + 1 : 0);
                }
                if(calNum)
                {
                    var numbers = Regex.Split(inputText, @"[^0-9]");
                    total += numbers.Sum(s => s == "" ? 0 : Int32.Parse(s));
                }
            }
            return total;
        }
    }
}