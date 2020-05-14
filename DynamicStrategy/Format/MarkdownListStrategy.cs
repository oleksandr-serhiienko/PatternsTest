using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicStrategy.Format
{
    public class MarkdownListStrategy : IListStrategy
    {
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.Append($" * {item}");
        }

        public void End(StringBuilder sb)
        {    
        }

        public void Start(StringBuilder sb)
        {            
        }
    }
}
