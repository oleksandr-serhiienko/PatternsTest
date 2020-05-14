using DynamicStrategy.Format;
using System;

namespace DynamicStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessor<MarkdownListStrategy>();
            tp.AppendList(new[] { "foo", "bar", "baz" });
            var tp2 = new TextProcessor<MarkdownListStrategy>();
        }
    }
}
