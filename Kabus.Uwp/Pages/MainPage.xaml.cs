using Windows.UI.Xaml.Controls;
using Kabus.Uwp.ViewModels;
using Movel.Uwp;
using MUXC = Microsoft.UI.Xaml.Controls;

namespace Kabus.Uwp.Pages
{
    public class MainPageBase : MovelPage<MainViewModel>
    {

    }

    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();
        }
    }
}
