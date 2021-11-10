using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Core.Entities.Store
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId {set; get;}
        public int SortOrder {set; get;}
        public bool IsHome {set; get;}
        [JsonIgnore]
        public List<Product> Products {set; get;}
    }
}