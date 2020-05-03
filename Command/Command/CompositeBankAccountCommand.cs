using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Command
{
    public class CompositeBankAccountCommand : List<BancAccountCommand>, ICommand
    {

        public CompositeBankAccountCommand()
        {

        }

        public CompositeBankAccountCommand(IEnumerable<BancAccountCommand> collection) : base(collection)
        {
        }

        public virtual bool Success 
        {
            get { return this.All(tr => tr.Success); }
            set
            {
                foreach (var cmd in this)
                    cmd.Success = value;
            }
        }

        public virtual void Call()
        {
            ForEach(cmd => cmd.Call());
        }

        public virtual void Undo()
        {
            foreach (var cmd in ((IEnumerable<BancAccountCommand>)this).Reverse())
            {
                if(cmd.Success) cmd.Undo();
            }
        }
    }
}
