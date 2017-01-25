using Caliburn.Micro;
using CryptoWizard.Services;
using System.Collections.Generic;

namespace CryptoWizard.ViewModels
{
  public class AdditionViewModel : ViewModelBase
  {
    private INavigationService _pageNavigationService;

    public AdditionViewModel(INavigationService pageNavigationService) : base(pageNavigationService)
    {
      _pageNavigationService = pageNavigationService;
      var add = new Inverse();
      IEnumerable<int> result = add.InverseResult(175, 192, 751);
    }
  }
}
