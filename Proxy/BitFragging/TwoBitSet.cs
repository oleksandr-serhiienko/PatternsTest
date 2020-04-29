using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Proxy.BitFragging
{

    public enum Op : byte
    {
        [Description("*")]
        Mul = 0,
        [Description("/")]
        Div = 1,
        [Description("+")]
        Add = 2,
        [Description("-")]
        Sub = 3
    }

    // Op -> name

    public static class OpImpl
    {
        static OpImpl()
        {
            var type = typeof(Op);
            foreach (Op op in Enum.GetValues(type))
            {
                MemberInfo[] memInfo = type.GetMember(op.ToString());
                if (memInfo.Length > 0)
                {
                    var attrs = memInfo[0].GetCustomAttributes(
                      typeof(DescriptionAttribute), false);

                    if (attrs.Length > 0)
                    {
                        opNames[op] = ((DescriptionAttribute)attrs[0]).Description[0];
                    }
                }
            }
        }

        private static readonly Dictionary<Op, char> opNames
          = new Dictionary<Op, char>();

        // notice the data types!
        private static readonly Dictionary<Op, Func<double, double, double>> opImpl =
          new Dictionary<Op, Func<double, double, double>>()
          {
              [Op.Mul] = ((x, y) => x * y),
              [Op.Div] = ((x, y) => x / y),
              [Op.Add] = ((x, y) => x + y),
              [Op.Sub] = ((x, y) => x - y),
          };

        public static double Call(this Op op, int x, int y)
        {
            return opImpl[op](x, y);
        }

        public static char Name(this Op op)
        {
            return opNames[op];
        }
    }

    public class TwoBitSet
    {
        private readonly ulong data;
        public TwoBitSet(ulong data)
        {
            this.data = data;
        }

        // 00 10 01 01 
        public byte this[int index]
        {
            get 
            {
                // 00 10 01 01
                var shift = index << 1;
                
                // 00 11 00 00
                ulong mask = (0b11U << shift);

                // 00 10 00 00 >> shift
                // 00 00 00 10
                return (byte)((data & mask) >> shift);
            }
        }
    }
}
