﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.CompositeProxy
{
    public class MasnorySettings
    {
        public bool? All
        {
            get 
            {
                if (flags.Skip(1).All(f => f == flags[0]))
                    return flags[0];
                return null;
            }
            set 
            {
                if (!value.HasValue) return;
                for (int i = 0; i < flags.Length; i++)
                {
                    flags[i] = value.Value;
                }
            }
        }
        //public bool? All
        //{
        //    get 
        //    {
        //        if (Pillars == Walls && Walls == Floors) return Pillars;
        //        else return null;
        //    }
        //    set 
        //    {
        //        if (!value.HasValue) return;
        //        Pillars = value.Value;
        //        Walls = value.Value;
        //        Floors = value.Value;
        //    }
        // }

        //public bool Pillars, Walls, Floors;

        private readonly bool[] flags = new bool[3];

        public bool Pillars
        {
            get => flags[0];
            set => flags[0] = value;
        }
        public bool Walls
        {
            get => flags[1];
            set => flags[1] = value;
        }
        public bool Floors
        {
            get => flags[2];
            set => flags[2] = value;
        }

    }
}
