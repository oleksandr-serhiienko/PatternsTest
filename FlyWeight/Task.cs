using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coding.Exercise
{
    public class Sentence
    {
        private List<string> words = new List<string>();
        private List<WordToken> formatting = new List<WordToken>();

        public Sentence(string plainText)
        {
            words = plainText.Split(' ').ToList();
        }

        public WordToken this[int index]
        {
            get
            {
                var wt = new WordToken { Index = index };
                if (formatting.Any(tr => tr.Index == wt.Index))
                    formatting.Remove(formatting.Single(tr => tr.Index == index));
                formatting.Add(wt);
                  return wt;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

   
            bool first = true;
            for (int i = 0; i < words.Count; i++)
            {             
                string newword = words[i];
                foreach (var range in formatting)
                {
                    if (range.Index == i && range.Capitalize)
                        newword = newword.ToUpper();
                    sb.Append(first ? newword : " " + newword);
                }                
                first = false;
            }
            return sb.ToString();
            
        }

        public class WordToken
        {
            public bool Capitalize;
            public int Index;
        }
    }
}
