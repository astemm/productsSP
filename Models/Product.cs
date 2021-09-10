using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ProductsSP.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        public Decimal Price { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Category? Category { get; set; }
        public string Characteristics { get; set; }
    }
}