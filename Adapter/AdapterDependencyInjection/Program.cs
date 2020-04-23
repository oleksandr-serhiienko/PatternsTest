using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.AdapterDependencyInjection
{
    public class Program
    {
        public interface ICommand
        {
            void Execute();
        }

        public class SaveCommand : ICommand
        {
            public void Execute()
            {
                Console.WriteLine("Saving a file"); ;
            }
        }

        public class OpenCommand : ICommand
        {
            public void Execute()
            {
                Console.WriteLine("Open a file");
            }
        }

        public class Button
        {
            private ICommand command;
            public Button(ICommand command)
            {
                this.command = command;
            }
            public void Click()
            {
                command.Execute();
            }
        }

        public class Editor
        {
            IEnumerable<Button> buttons;

            public Editor(IEnumerable<Button> buttons)
            {
                this.buttons = buttons;

            }

            public void ClickAll()
            {
                foreach (var b in buttons)
                    b.Click();
                
            }
        }

        static void Main(string[] args)
        {
            var b = new ContainerBuilder();
            b.RegisterType<SaveCommand>().As<ICommand>();
            b.RegisterType<OpenCommand>().As<ICommand>();
            //b.RegisterType<Button>();
            b.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));
            b.RegisterType<Editor>();

            using var c = b.Build();
            var editor = c.Resolve<Editor>();
            editor.ClickAll();

        }


    }
}
