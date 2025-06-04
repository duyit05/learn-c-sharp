using System;

namespace NamespaceAndPartial
{
    public partial class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string GetInfo()
        {
            return $"{Name} / {Price} ==> {Description}";
        }
    }
}