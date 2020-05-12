using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Observer.PropertyDependencies
{
    public class Person : PropertyNotificationSupport
    {
        private int age;
        private bool citizen;
        public int Age 
        { 
            get => age;
            set 
            {
                if (value == age) return;
                age = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CanVote));
            } 
        }

        public bool Cititzen
        {
            get => citizen;
            set
            {
                if (value == citizen) return;
                citizen = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CanVote));
            }
        }

        private readonly Func<bool> canVote;
        public bool CanVote => canVote();

        public Person()
        {
            canVote = property(nameof(canVote), () => Age >= 16 && Cititzen);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
