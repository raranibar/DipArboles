using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arboles.ViewModels
{
    public class RegistraArbolPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
        public RegistraArbolPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
