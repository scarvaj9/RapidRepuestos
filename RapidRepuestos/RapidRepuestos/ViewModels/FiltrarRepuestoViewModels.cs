﻿namespace RapidRepuestos.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class FiltrarRepuestoViewModels
    {

        public string FiltrarRepuesto { get; set; }


        public FiltrarRepuestoViewModels()
        {


        }



        public ICommand BuscarRepuesto
        {
            get
            {
                return new RelayCommand(Buscar);
            }
        }


        private async void Buscar()
        {


            if (string.IsNullOrEmpty(this.FiltrarRepuesto))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "no ingreso el repuesto de la moto que buscas",
                    "Aceptar");

            }

            if (FiltrarRepuesto == "piston")
            {

                MainViewModels.GetInstance().Tienda = new ListarTiendaViewModels();
                await Application.Current.MainPage.Navigation.PushAsync(new ListaTiendasPage());

            }

           
        }

    }
}
