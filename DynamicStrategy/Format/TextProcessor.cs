using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicStrategy.Format
{
    public class TextProcessor<LS> where LS: IListStrategy, new()
    {
        StringBuilder sb = new StringBuilder();
        IListStrategy listStrategy = new LS();

        public TextProcessor()
        {
                
        }

        public void AppendList(IEnumerable<string> items)
        {
            listStrategy.Start(sb);
            foreach (var item in items)
                listStrategy.AddListItem(sb, item);
            listStrategy.End(sb);
        }

        public override string ToString()
        {
            return sb.ToString();
        }

        public StringBuilder Clear()
        {
            return sb.Clear();
        }
    }
}
