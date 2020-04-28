using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight
{
    public class FormatedText
    {
        private readonly string plainText;
        private bool[] capitalized;
        public FormatedText(string plainText)
        {
            this.plainText = plainText;
            capitalized = new bool[plainText.Length];
        }

        public void Capitalize(int start, int end)
        { 
            for (int i = start; i <= end; i++)
            {
                capitalized[i] = true;
            }
        }       

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < plainText.Length; i++)
            {
                var c = plainText[i];
                sb.Append(capitalized[i] ? char.ToUpper(c) : c);
            }
            return sb.ToString();
        }
    }
}
