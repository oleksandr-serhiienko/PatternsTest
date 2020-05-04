using System;
using System.Collections.Generic;
using System.Text;

namespace Intepreter
{
    public class Token
    {
        public enum Type
        {
            Integer, Plus, Minus, Lparen, Pparen
        }

        public Type MyType;
        public string Text;

        public Token(Type myType, string text)
        {
            MyType = myType;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Text}"; 
        }
    }
}
