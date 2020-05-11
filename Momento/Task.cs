using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Exercise
{
    public class Token
    {
        public int Value = 0; 

        public Token(int value)
        {
            this.Value = value;
        }
    }

    public class Memento
    {

        public Memento(Token token)
        {
            Token = token;
        }
        public Token Token { get; }
    }

    public class TokenMachine
    {
        public List<Token> Tokens = new List<Token>();
        private List<Memento> changes = new List<Memento>();
        private int current;

        public TokenMachine()
        {
            current = 0;
        }


        public Memento AddToken(int value)
        {
            current++;
            var t = new Token(value);
            var m = new Memento(t);
            Tokens.Add(t);
            changes.Add(m);
            return m;
        }

        public Memento AddToken(Token token)
        {
            current++;
            var m = new Memento(token);
            Tokens.Add(token);
            changes.Add(m);
            return m;
        }

        public void Revert(Memento m)
        {
            Tokens.Remove(changes.First(tr => tr.Equals(m)).Token);
            changes.Add(m);
        }
    }
}
