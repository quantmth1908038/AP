using System;

namespace Practice
{
    abstract class Product
    {
        protected int id;
        protected string name;
        protected double price;
        protected string producer;

        public Product(int id, string name, double price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public abstract double computeTax();


    }

    class Book : Product
    {
        public Book(int id, string name, double price, string producer) : base(id, name, price, producer){}

        public override double computeTax()
        {
            return price * 0.08;
        }

        public override string ToString()
        {
            return "id: " + this.id + ", name: " + this.name + ", price: " + this.price + ", producer:  " + this.producer;
        }
    }

    class MobilePhone : Product
    {
        public MobilePhone(int id, string name, double price, string producer) : base(id, name, price, producer) { }

        public override double computeTax()
        {
            return price * 0.1;
        }

        public override string ToString()
        {
            return "id: " + this.id + ", name: " + this.name + ", price: " + this.price + ", producer:  " + this.producer;
        }
    }

    class MainProduct
    {
        static void Main(string[] args)
        {
            double TotalTax = 0; 

            Product[] products = new Product[6];
            products[0] = new Book(1, "Toi thay hoa vang tren co xanh", 100000, "Kim Dong");
            products[1] = new Book(2, "Sherlock holems", 150000, "Phuong Nam");
            products[2] = new Book(3, "Learn Code", 80000, "Kim Dong");
            products[3] = new MobilePhone(4, "Galaxy S9", 15000000, "SumSung");
            products[4] = new MobilePhone(5, "IphoneX", 15000000, "Apple");
            products[5] = new MobilePhone(6, "Oppo 11", 15000000, "Oppo");

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(products[i].ToString() + ", Tax: " + products[i].computeTax());
                TotalTax += products[i].computeTax(); 
            }

            Console.WriteLine("Total Tax: " + TotalTax);

        }
    }

}
