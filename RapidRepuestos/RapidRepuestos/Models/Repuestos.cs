namespace RapidRepuestos.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    class Repuestos
    {
        [JsonProperty(PropertyName = "products")]
        public List<Product> Products { get; set; }
    }
}
