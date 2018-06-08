namespace RapidRepuestos.Models
{   using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;


    public class Image2
    {
        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public object Product_id { get; set; }

        [JsonProperty(PropertyName = "position")]
        public int Position { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created_at { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime Updated_at { get; set; }

        [JsonProperty(PropertyName = "alt")]
        public object Alt { get; set; }

        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "src")]
        public string Src { get; set; }

        [JsonProperty(PropertyName = "variant_ids")]
        public List<object> Variant_ids { get; set; }

    }
}
