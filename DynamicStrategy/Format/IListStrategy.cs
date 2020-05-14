using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicStrategy.Format
{
    public interface IListStrategy
    {
        void Start(StringBuilder sb);
        void End(StringBuilder sb);
        void AddListItem(StringBuilder sb, string item);
    }
}
