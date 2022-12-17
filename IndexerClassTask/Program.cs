using System;

namespace IndexerClassTask
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Store store = new Store(6);
            store[1] = new Product()
            {
                Name = "product1",
                Price = 500
            };
            store[2] = new Product()
            {
                Name = "product2",
                Price = 400,
            };
            store[3] = new Product()
            {
                Name = "product3",
                Price = 300,
            };
            store[4] = new Product()
            {
                Name = "product4",
                Price = 200,
            };
            store[5] = new Product()
            {
                Name = "product5",
                Price = 100,
            };
            foreach (var item in store)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
