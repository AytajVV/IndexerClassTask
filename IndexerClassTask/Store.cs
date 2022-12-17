using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IndexerClassTask
{
    public class Store:IEnumerable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        private Product[] products;

        public Store(int size)
        {
            products = new Product[size];
        }

        public Product this[int index]
        {
            get
            {
                return products[index];
            }
            set
            {
                if (products.Length<index)
                {
                    Console.WriteLine("blabla");
                    return;
                }
                products[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return products.GetEnumerator();
        }
    }
}
