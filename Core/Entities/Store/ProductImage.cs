using System.Text.Json.Serialization;

namespace Core.Entities.Store
{
    public class ProductImage : BaseEntity
    {
        public string Url {set; get;}
        public int ProductId {set; get;}
        [JsonIgnore]
        public Product Product {set; get;}
    }
}