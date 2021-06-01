using System;
using System.Collections.Generic;
using System.Text;

namespace _014Task2Basic
{
    class MyList<T>
    {
        private T[] array = null;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            T[] extendedList = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                extendedList[i] = array[i];
            }
            extendedList[extendedList.Length - 1] = item;
            array = extendedList;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Count
        {
            get
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].ToString() != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }



        public bool Search(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    Console.WriteLine("Элемент найден");
                    Console.WriteLine("Элемент массива содержится под индексом  " + i);
                    return true;
                }
            }
            Console.WriteLine("Элемент не найден");
            return false;


        }
        public override string ToString()
        {
            string arrayElement = null;
            for (int i = 0; i < array.Length; i++)
            {
                arrayElement += array[i] + " ";
            }
            return "Размерность массива " + array.Length + " Элементы массива:" + arrayElement;
        }
        int position = -1; 
        public IEnumerator<T> GetEnumerator() 
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++; 
                    yield return array[position];
                }
                else
                {
                    yield break;
                }
            }
        }
    }

}
