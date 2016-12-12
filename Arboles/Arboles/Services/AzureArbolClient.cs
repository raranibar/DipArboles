using Arboles.Model;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arboles.Services{
    public class AzureArbolClient {
        private IMobileServiceClient _client;
        private IMobileServiceTable<Ficha> _table;
        private const string serviceUri = "http://ralarbol.azurewebsites.net/";
        public AzureArbolClient(){
            _client = new MobileServiceClient(serviceUri);
            _table = _client.GetTable<Ficha>();
        }
        public async Task<IEnumerable<Ficha>> GetFichasArbol(){
            var empty = new Ficha[0];
            try{
                return await _table.ToEnumerableAsync();
            }catch (Exception ex){
                return empty;
            }
        }

        public async void AddFichaArbol(Ficha ficha){
            await _table.InsertAsync(ficha);
        }        
    }
}
