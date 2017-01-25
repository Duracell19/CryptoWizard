using Caliburn.Micro;

namespace CryptoWizard.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private int _index;

        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                NotifyOfPropertyChange(() => Index);
            }
        }

        private INavigationService _pageNavigationService;

        public MainPageViewModel(INavigationService pageNavigationService) : base(pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
        }

        public void SelectMenuCommand()
        {
            switch(Index)
            {
                case 0: break;
                case 1: break;
                case 2: _pageNavigationService.NavigateToViewModel<AdditionViewModel>(); break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                case 7: break;
                default: break;
            }
        }
    }
}