using Customer;
using Order;
using System;
using System.Collections.Generic;

namespace Customer
{
    class CostomerName
    {
        string Name;
        public void ReadName()
        {
            Console.Write("Enter costomer name: ");
            Name = Console.ReadLine();
        }
        public String getName()
        {
            return this.Name;
        }

    }

}
namespace Order
{
    class GroceryItems
    {
        int n;
        List<String> items = new List<string>();
        public void Items()
        {
           
            do
            {
                do
                {
                    Console.Write("List Grocery Items: \n" +
                    "1. Newspaper \n" +
                    "2. Snack \n" +
                    "3. Candy \n" +
                    "4. Milk \n" +
                    "0. Back \n" +
                    "Choose Items: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                while (n < 0 || n > 4);
                switch (n)
                {
                    case 1:
                        items.Add("Newspaper");
                        break;
                    case 2:
                        items.Add("Snack");
                        break;
                    case 3:
                        items.Add("Candy");
                        break;
                    case 4:
                        items.Add("Milk");
                        break;
                }
            } 
            while (n!=0);

        }

        public void ReadItems()
        {
            foreach(string item in items){
                Console.WriteLine(item);
            }
        }
    }

    class BakeryProducts
    {
        int n;
        List<String> Bakerys = new List<string>();
        public void Bakery()
        {
            
            do
            {
                do
                {
                    Console.Write("List Bakery: \n" +
                    "1. Cupcake \n" +
                    "2. Cookie \n" +
                    "3. Donut \n" +
                    "4. Mochi \n" +
                    "0. Back \n" +
                    "Choose Bakery: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                while (n < 0 || n > 4);
                switch (n)
                {
                    case 1:
                        Bakerys.Add("Cupcake");
                        break;
                    case 2:
                        Bakerys.Add("Cookie");
                        break;
                    case 3:
                        Bakerys.Add("Donut");
                        break;
                    case 4:
                        Bakerys.Add("Mochi");
                        break;
                }
            }
            while (n != 0);
        }
        public void ReadBakery()
        {
            foreach (string b in Bakerys)
            {
                Console.WriteLine(b);
            }
        }
    }
}
namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CostomerName name = new CostomerName();
            GroceryItems item = new GroceryItems();
            BakeryProducts bakery = new BakeryProducts();
            int n = 0;
            name.ReadName();
            do
            {
                Console.Write("Orders: \n" +
                    "1. Grocery Items \n" +
                    "2. Bakery Products \n" +
                    "Choose: ");
                n = Convert.ToInt32(Console.ReadLine());
                while (n < 0 || n > 2)
                {
                    Console.Write("Order: \n" +
                    "1. Grocery Items \n" +
                    "2. Bakery Products \n" +
                    "Choose: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                switch (n)
                {
                    case 1:
                       
                        item.Items();
                        
                        break;
                    case 2:
                        bakery.Bakery();
                        break;
                }
            }
            while (n != 0);
            Console.WriteLine("------------- \n" + name.getName());
            item.ReadItems();
            bakery.ReadBakery();

        }


    }
}
