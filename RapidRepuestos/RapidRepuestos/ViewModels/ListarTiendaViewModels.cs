
namespace RapidRepuestos.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using Models;
    using Services;

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
        }
    }
}
