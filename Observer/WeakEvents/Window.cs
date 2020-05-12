using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.WeakEvents
{
    public class Window
    {
        public Window(Button button)
        {
            button.Clicked += ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button was cliked wh");
        }

        ~Window()
        {
            Console.WriteLine("Window finalized");
        }
    }
}
