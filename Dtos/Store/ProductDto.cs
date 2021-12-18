using System;
using System.Collections.Generic;

namespace Dtos.Store
{
    public class ProductDto
    {
        public int Id {set; get;}
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsHome { get; set; }
        public string Frame {set; get;}
        public DateTime DateCreated {set; get;}
        public List<string> ProductImages {set; get;}
    }
}