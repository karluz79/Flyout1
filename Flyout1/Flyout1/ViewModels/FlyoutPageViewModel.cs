using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flyout1.ViewModels
{
    public class FlyoutPageViewModel : INotifyPropertyChanged
    {
        public FlyoutPageViewModel()
        {

        }

        public string MyTestString = "AnyString";

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}