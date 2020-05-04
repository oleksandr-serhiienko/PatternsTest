using System;
using System.Collections.Generic;
using System.Text;

namespace Intepreter
{
    public class BinaryOperation : IElement
    {
        public int Value
        {
            get
            {
                switch (MyType)
                {
                    case Type.Addition:
                        return Left.Value + Right.Value;
                    case Type.Substraction:
                        return Left.Value - Right.Value;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public enum Type
        {
            Addition, Substraction
        }

        public Type MyType;
        public IElement Left, Right;
    }
}
