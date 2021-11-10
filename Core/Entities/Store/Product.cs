using System;
using System.Collections.Generic;

namespace Core.Entities.Store
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsHome { get; set; }
        public string Frame {set; get;}
        public DateTime DateCreated {set; get;}
        public int CategoryId {set; get;}
        public Category Category {set; get;}
        public List<ProductImage> ProductImages {set; get;}
    }
}