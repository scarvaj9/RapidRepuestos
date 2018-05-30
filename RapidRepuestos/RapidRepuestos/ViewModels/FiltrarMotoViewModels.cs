

namespace RapidRepuestos.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class FiltrarMotoViewModels
    {


        //propiedades de filtrar moto que vienen de filtromotopage


        public string MarcaMoto { get; set; }

        public string TipoMoto { get; set; }

        public string MotoExacta { get; set; }



        // aca vamos a poner los constructores 
        public FiltrarMotoViewModels()
        {
          

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
            if (string.IsNullOrEmpty(this.MarcaMoto) || string.IsNullOrEmpty(this.TipoMoto) || string.IsNullOrEmpty(this.MotoExacta))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "campo no diligenciado",
                    "Aceptar");
                return;
            }

            if (MarcaMoto == "auteco")
            {
                if (TipoMoto == "street")
                {
                    if (MotoExacta == "pulsar")
                    {
                        MainViewModels.GetInstance().Repuesto = new FiltrarRepuestoViewModels();
                        await Application.Current.MainPage.Navigation.PushAsync(new FiltrarRepuestoPage());

                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert(
                 "Error",
                 "moto no encontrada ",
                 "Aceptar");
                        return;
                    }


                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(
                 "Error",
                 "tipo no encontrado ",
                 "Aceptar");
                    return;
                }

            }
            else { await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "marca no encontrada ",
                   "Aceptar");
            return;}
            
           

        }



    }
}
