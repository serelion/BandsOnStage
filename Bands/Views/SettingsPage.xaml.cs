using Bands.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Bands.Views
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Disabled;
        }

        // strongly-typed view models enable x:bind
        public SettingsPageViewModel ViewModel => this.DataContext as SettingsPageViewModel;
    }
}

