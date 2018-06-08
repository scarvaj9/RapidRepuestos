namespace RapidRepuestos.Models
{
    using Newtonsoft.Json;
    using System;

    public class Variant
    {
        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        [JsonProperty(PropertyName = "product_id")]
        public object Product_id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        [JsonProperty(PropertyName = "position")]
        public int Position { get; set; }

        [JsonProperty(PropertyName = "inventory_policy")]
        public string Inventory_policy { get; set; }

        [JsonProperty(PropertyName = "compare_at_price")]
        public object Compare_at_price { get; set; }

        [JsonProperty(PropertyName = "fulfillment_service")]
        public string Fulfillment_service { get; set; }

        [JsonProperty(PropertyName = "inventory_management")]
        public object Inventory_management { get; set; }

        [JsonProperty(PropertyName = "option1")]
        public string Option1 { get; set; }

        [JsonProperty(PropertyName = "option2")]
        public object Option2 { get; set; }

        [JsonProperty(PropertyName = "option3")]
        public object Option3 { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created_at { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime Updated_at { get; set; }

        [JsonProperty(PropertyName = "taxable")]
        public bool Taxable { get; set; }

        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }

        [JsonProperty(PropertyName = "grams")]
        public int Grams { get; set; }

        [JsonProperty(PropertyName = "image_id")]
        public object Image_id { get; set; }

        [JsonProperty(PropertyName = "inventory_quantity")]
        public int Inventory_quantity { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public double Weight { get; set; }

        [JsonProperty(PropertyName = "weight_unit")]
        public string Weight_unit { get; set; }

        [JsonProperty(PropertyName = "inventory_item_id")]
        public object Inventory_item_id { get; set; }

        [JsonProperty(PropertyName = "old_inventory_quantity")]
        public int Old_inventory_quantity { get; set; }

        [JsonProperty(PropertyName = "requires_shipping")]
        public bool Requires_shipping { get; set; }
    }
}
