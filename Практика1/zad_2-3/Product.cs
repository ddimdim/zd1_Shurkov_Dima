using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    class Product
    {
        public decimal price { get; set; }
        public string name { get; set; }

        public Product (string Name, decimal Price)
        {
            this.name = Name;
            this.price = Price;
        }
        public string GetInfo ()
        {
            return $"Наименование: {name}; Цена: {price}";
        }
    }
}
