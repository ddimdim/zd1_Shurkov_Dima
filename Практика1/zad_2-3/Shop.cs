using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_2
{
    class Shop
    {
        public Dictionary<Product, int> products;
        public decimal Profit { get; set; }
        public Shop ()
        {
            products = new Dictionary<Product, int>();
        }
        public void CreateProduct (string name, decimal price, int count)
        {
            Product product = new Product(name, price);
            products.Add(product, count);
        }
        public void WriteAllProducts (ListBox listBox1)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Список продуктов: ");
            foreach (var product in products)
            {
                listBox1.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);
            }
        }
        public void Sell (Product product)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 1)
                {
                    MessageBox.Show("Куплен последний товар", "Осторожно");
                    products.Remove(product);
                } else
                {
                    products[product]--;
                    Profit += product.price;
                    MessageBox.Show("Товар куплен", "Успех");
                }
            } else
            {
                MessageBox.Show("Товар не найдет", "Ошибка");
            }
        }
        public Product FindByName (string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.name == name)
                {
                    return product;
                }
            }
            return null;
        }

    }
}
