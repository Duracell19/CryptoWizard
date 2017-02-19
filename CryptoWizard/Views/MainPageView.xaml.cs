using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CryptoWizard.Views
{
  public sealed partial class MainPageView : Page
  {
    public MainPageView()
    {
      this.InitializeComponent();
      SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
    }

    private void HamburgerButton_Click(object sender, RoutedEventArgs e)
    {
      MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
    }
  }
}
