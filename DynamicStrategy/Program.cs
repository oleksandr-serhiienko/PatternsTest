using DynamicStrategy.Format;
using System;

namespace DynamicStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "foo", "bar", "baz" });
        }
    }
}
