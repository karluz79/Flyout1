using Flyout1.Resources;
using Flyout1.Views;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Flyout1.ViewModels
{
    public class FlyoutPageViewModel : INotifyPropertyChanged
    {
        public FlyoutPageViewModel()
        {

        }

        private string teste1 = "String 1";
        private string teste2 = "String 2";
        private string teste3 = "String 3";

        public List<FlyoutPageItem> flyoutPageItems
        {
            get
            {
                return new List<FlyoutPageItem>
                    {
                        new FlyoutPageItem {
                            Title=teste1,
                            IconSource="door_light.png",
                            TargetType= typeof(DoorPage)
                        },
                        new FlyoutPageItem {
                            Title=teste2,
                            IconSource="company_light.png",
                            TargetType= typeof(AboutPage)
                        },
                        new FlyoutPageItem {
                            Title=teste3,
                            IconSource="config_light.png",
                            TargetType= typeof(ContactsPage)
                        }
                    };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}