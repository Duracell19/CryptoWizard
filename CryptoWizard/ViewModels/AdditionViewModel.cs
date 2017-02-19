using Caliburn.Micro;
using CryptoWizard.Services;

namespace CryptoWizard.ViewModels
{
  public class AdditionViewModel : ViewModelBase
  {
    private INavigationService _pageNavigationService;

    public AdditionViewModel(INavigationService pageNavigationService) : base(pageNavigationService)
    {
      _pageNavigationService = pageNavigationService;
      //var add = new ElectronicDigitalSignature();
      //IEnumerable<int> result = add.GenerateEDS(416, 55, Encoding.UTF8.GetBytes("Hello world"), 2, 728, 5, -1, 751); // 12 и 3 случайные числа от 0 до n
      //bool res = add.CheckEDS(384, 475, result.ElementAt(0), result.ElementAt(1), Encoding.UTF8.GetBytes("Hello world"), 12, 728, -1, 751);
      var s = new Addition();
      var result = s.AdditionNeuralNetworkResult(82, 481, 83, 373, -1, 751);
    }
  }
}
