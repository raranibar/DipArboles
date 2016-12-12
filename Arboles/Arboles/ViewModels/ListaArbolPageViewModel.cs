using Arboles.Model;
using Arboles.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Arboles.ViewModels
{
    public class ListaArbolPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }
        public ObservableCollection<Ficha> Fichas { get; set; }
        private AzureArbolClient _client;
        //public DelegateCommand RefreshCommand { get; private set; }
        public DelegateCommand CargarListaFicha { get; private set; }
        public ListaArbolPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _client = new AzureArbolClient();
            Fichas = new ObservableCollection<Ficha>();
            //RefreshCommand = DelegateCommand.FromAsyncHandler(async () => await LoadFichaArboles());
            CargarListaFicha = DelegateCommand.FromAsyncHandler(async () => await LoadFichaArboles());
        }

        private async Task LoadFichaArboles()
        {
            if (IsBusy)
                return;
            var result = await _client.GetFichasArbol();
            Fichas.Clear();
            foreach (var item in result)
            {
                Fichas.Add(item);
            }
            IsBusy = false;
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
