namespace RapidRepuestos.ViewModels
{

    public class MainViewModels
    {
        public FiltrarMotoViewModels Filtrar { get; set; }

        public FiltrarRepuestoViewModels Repuesto { get; set; }

        public MainViewModels()
        {
            instance = this;
            this.Filtrar = new FiltrarMotoViewModels();

        }

        // se hace un singleton para evitar instanciar varias veces la principal class 

        private static MainViewModels instance;

        public static MainViewModels GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModels();
            }

            return instance;
        }
    }   

}
