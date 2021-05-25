using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Task4Basic
{
    class Article
    {
        private string NameProduct;
        private string NameShop;
        private double price;
        public void Input(string product, string shop, double cost)
        {
            NameProduct = product;
            NameShop = shop;
            price = cost;
        }
        public override string ToString()
        {
            return "Называние товара:"+ NameProduct + "    Называние магазина:" + NameShop + "  Цена:" + price + " Сом. ";
        }

    }
}

