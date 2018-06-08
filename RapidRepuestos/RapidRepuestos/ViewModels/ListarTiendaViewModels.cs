
namespace RapidRepuestos.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Models;
    using Services;
    using Xamarin.Forms;

    public class ListarTiendaViewModels
    {
        private ApiService apiService;
        
        // atributo 
        private ObservableCollection<Repuesto> repuestos;


        // properties
        public ObservableCollection<Repuesto> Repuesto
        {

            get { return this.repuestos; }
            set { SetValue(ref this.repuestos, value); }

        }

        private void SetValue(ref ObservableCollection<Repuesto> repuestos, ObservableCollection<Repuesto> value)
        {
            throw new NotImplementedException();
        }

        public ListarTiendaViewModels()
        {
            this.apiService = new ApiService();
            this.LoadRepuestos();

        }

        private async void LoadRepuestos()
        {
            var response = await this.apiService.GetList<Repuesto>(
                "https://storerepuestos.myshopify.com",
                "/admin",
                "/products.json");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }
            var list = (List<Repuesto>)response.Result;
            this.Repuesto = new ObservableCollection<Repuesto>(list);
            
        }
    }
}
