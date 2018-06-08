namespace RapidRepuestos.Models
{   using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public class Product
    {
        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "body_html")]
        public string Body_html { get; set; }

        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }

        [JsonProperty(PropertyName = "product_type")]
        public string Product_type { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created_at { get; set; }

        [JsonProperty(PropertyName = "handle")]
        public string Handle { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime Updated_at { get; set; }

        [JsonProperty(PropertyName = "published_at")]
        public DateTime Published_at { get; set; }

        [JsonProperty(PropertyName = "template_suffix")]
        public object Template_suffix { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonProperty(PropertyName = "published_scope")]
        public string Published_scope { get; set; }

        [JsonProperty(PropertyName = "variants")]
        public List<Variant> Variants { get; set; }

        [JsonProperty(PropertyName = "options")]
        public List<Option> Options { get; set; }

        [JsonProperty(PropertyName = "images")]
        public List<Image> Images { get; set; }

        [JsonProperty(PropertyName = "image")]
        public Image2 Image { get; set; }

    }
}
