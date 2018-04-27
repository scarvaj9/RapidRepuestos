

namespace RapidRepuestos.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class FiltrarMotoViewModels
    {


        //propiedades de filtrar moto que vienen de filtromotopage

        public bool Prueba { get; set; }

        public string MarcaMoto { get; set; }

        public string TipoMoto { get; set; }

        public string MotoExacta { get; set; }



        // aca vamos a poner los constructores 
        public FiltrarMotoViewModels()
        {
            this.Prueba = true;

        }

        // los botones o commands los ponemos por aparte pero tambien son propiedades
        public ICommand BuscarMoto
        {
            get
            {
                return new RelayCommand(Buscar);
            }
        }



        private async void Buscar()
        {
            if (string.IsNullOrEmpty(this.MarcaMoto))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "no ingreso la marca de la moto",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.TipoMoto))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "no ingreso el tipo de moto",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.MotoExacta))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "no ingreso el nombre de la moto ",
                    "Aceptar");
                return;
            }
            MainViewModels.GetInstance().Repuesto = new FiltrarRepuestoViewModels();
            await Application.Current.MainPage.Navigation.PushAsync(new FiltrarRepuestoPage());

        }



    }
}
