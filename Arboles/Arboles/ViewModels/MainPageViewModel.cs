using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arboles.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
        public DelegateCommand NavComListaArbol { get; private set; }
        public DelegateCommand NavComRegistraArbol { get; private set; }        

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavComListaArbol = new DelegateCommand(NavigateListaArbol);
            NavComRegistraArbol = new DelegateCommand(NavigateRegistraArbol);
        }
        private void NavigateListaArbol()
        {
            _navigationService.NavigateAsync("ListaArbolPage");
        }

        private void NavigateRegistraArbol()
        {
            _navigationService.NavigateAsync("RegistraArbolPage");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //if (parameters.ContainsKey("title"))
            //    Title = (string)parameters["title"] + " and Prism";
        }
    }
}
