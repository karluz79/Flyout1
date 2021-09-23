using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flyout1.Resources
{
    public class FlyoutPageItem : INotifyPropertyChanged
    {
        public string Title
        {
            get; set;
        }
        public string IconSource
        {
            get; set;
        }
        public Type TargetType
        {
            get; set;
        }

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}