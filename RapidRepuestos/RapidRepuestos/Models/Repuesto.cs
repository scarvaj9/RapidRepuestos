namespace RapidRepuestos.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

   public class Repuesto
    {
        [JsonProperty(PropertyName = "products")]
        public List<Product> Products { get; set; }
    }
}
