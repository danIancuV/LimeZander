using System;

namespace Data.LimeZander.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; } 
        public string Description { get; set; }
        public uint Cost { get; set; }
        public int SoldQuantity { get; set; }
        public uint Price { get; set; }
    }

    public enum ProductType
    {
       Mulineta,
       Lanseta,
       AccesoriiBagajerie
    }
}
