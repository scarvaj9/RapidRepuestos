namespace RapidRepuestos.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Option
    {
        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public object Product_id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "position")]
        public int Position { get; set; }

        [JsonProperty(PropertyName = "values")]
        public List<string> Values { get; set; }

    }
}
