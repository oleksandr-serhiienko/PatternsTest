using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.ValueProxy
{
    public static class PercentageExtensions
    {
        public static Percentage Percent(this float value)
        {
            return new Percentage(value / 100f);
        }
        public static Percentage Percent(this int value)
        {
            return new Percentage(value / 100f);
        }
    }
}
