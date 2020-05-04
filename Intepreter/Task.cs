using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.Exercise
{
    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        public int Calculate(string expression)
        {
            var tokens = Lex(expression);

            var parsed = Parse(tokens);
            return parsed.Value;
        }

        static IElement Parse(IReadOnlyList<Token> tokens)
        {
            var result = new BinaryOperation();
            bool haveLHS = false;
            for (int i = 0; i < tokens.Count; i++)
            {
                var token = tokens[i];

                // look at the type of token
                switch (token.MyType)
                {
                    case Token.Type.Integer:
                        var integer = new Integer(int.Parse(token.Text));
                        if (!haveLHS)
                        {
                            result.Left = integer;
                            haveLHS = true;
                        }
                        else
                        {
                            result.Right = integer;
                        }
                        break;
                    case Token.Type.Plus:
                        result.MyType = BinaryOperation.Type.Addition;
                        break;
                    case Token.Type.Minus:
                        result.MyType = BinaryOperation.Type.Substraction;
                        break;                 
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return result;
        }


        static List<Token> Lex(string input)
        {
            var result = new List<Token>();
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '+':
                        result.Add(new Token(Token.Type.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token(Token.Type.Minus, "-"));
                        break;                   
                    default:
                        var sb = new StringBuilder(input[i].ToString());
                        for (int j = i + 1 ; j < input.Length; ++j)
                        {
                            if (char.IsDigit(input[j]))
                            {
                                sb.Append(input[j]);
                                ++i;
                            }
                            else
                            {                                
                                break;
                            }
                        }
                        result.Add(new Token(Token.Type.Integer, sb.ToString()));
                        break;
                }
            }
            return result;
        }


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
        public interface IElement
        {
            int Value { get; }

        }

        public class Integer : IElement
        {
            public int Value { get; }

            public Integer(int value)
            {
                this.Value = value;
            }
        }

        public class Token
        {
            public enum Type
            {
                Integer, Plus, Minus
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
}
