namespace RapidRepuestos.ViewModels
{   

    public class MainViewModels
    {
        public FiltrarMotoViewModels Filtrar { get; set; }

        public FiltrarRepuestoViewModels Repuesto { get; set; }

        public ListarTiendaViewModels Tienda { get; set; }

        

        public MainViewModels()
        {
            instance = this;
            this.Filtrar = new FiltrarMotoViewModels();

        }

       // private string AddProduct(string shopifyProduct)
      //  {
       //     shopifyProduct = "{" + "\"product\":" + shopifyProduct + "}";
        //    var client = new RestClient(“https://yourStoreURL”);
        //    var request = new RestRequest("/admin/products.json", Method.POST);
         //   request.AddHeader("X-Shopify-Access-Token", “Your stores API Key”);
         //   request.AddParameter("application/json; charset=utf-8", shopifyProduct, ParameterType.RequestBody);
         //   request.RequestFormat = DataFormat.Json;
         //   var restResponse = client.Execute(request);

         //   return restResponse.StatusCode.ToString();
      //  }

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
