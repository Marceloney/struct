using System;
using System.Security.Cryptography.X509Certificates;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product mouse = new Product(1, "Mouse Gamer", 299.97, EproductType.Product);
            var manutecaoEletrica = new Product(2, "Manutenção Elétrica residencial", 500, EproductType.Product);
            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);

        }


        struct Product
        {
            public Product(int id, string name, double price, EproductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;
                

            }
            public int Id;
            public string Name;
            public double Price;
            public EproductType Type;

            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }
        }

        enum EproductType
        {
            Product = 1,
            Service = 2
        }

    }

}

