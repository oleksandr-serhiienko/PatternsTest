using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace StateDesignPatterm.CombinationLock
{
    class Prog
    {
        static void Main(string[] args)
        {
            string code = "1234";
            var state = State.Locked;
            var entry = new StringBuilder();

            while (true)
            {
                switch (state)
                {
                    case State.Locked:
                        entry.Append(Console.ReadKey().KeyChar);
                        if (entry.ToString() == code)
                        {
                            state = State.Unlocked;
                            break;
                        }
                        if (!code.StartsWith(entry.ToString()))
                        {
                            state = State.Fail;
                            break;
                        }
                        break;
                    case State.Fail:
                        Console.CursorLeft = 0;
                        Console.WriteLine("FAILED");
                        entry.Clear();
                        state = State.Locked;
                        break;
                    case State.Unlocked:
                        Console.CursorLeft = 0;
                        Console.WriteLine("Unlocked");
                        return;
                }
            }
        }
    }
}
