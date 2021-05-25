using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Task4Basic
{
    class Store
    {
        private Article[] baza = new Article[6];

        public Store()
        {
            for (int i = 0; i < baza.Length; i++)
            {
                baza[i] = new Article();
            }
            baza[0].Input("Холодильник", "технодом", 12000.5);
            baza[1].Input("Чайник", "эльдорадо", 600);
            baza[2].Input("Телевизор", "технодом", 15000.7);
            baza[3].Input("Ноутбук", "технодом", 45000.5);
            baza[4].Input("Кофебарка", "эльдорадо", 5000);
            baza[5].Input("Клавиатура", "технодом", 1500.5);
        }

        public int Size()
        {
            return baza.Length;
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < baza.Length)
                    return baza[index].ToString();

                else
                    return "Попытка выхода за пределы массива";
            }
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < baza.Length; i++)

                    if (baza[i].ToString().Contains(index))
                        return baza[i].ToString();

                return "Такого товара нет";

            }
        }
    }
}
