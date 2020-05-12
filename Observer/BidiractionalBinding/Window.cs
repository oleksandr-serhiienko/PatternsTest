using JetBrains.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Observer.BidiractionalBinding
{
    public class Window : INotifyPropertyChanged
    {
        private string productName;
        public string ProductName
        {
            get => productName;
            set
            {
                if (value == productName) return;
                productName = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            return $"Window: {ProductName}";
        }
    }
}
