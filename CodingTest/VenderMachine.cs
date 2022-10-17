using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public static class VenderMachine
    {
        public static int WantProduct()
        {
            Console.WriteLine("Select Product : ");
            int productID = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (productID > 0 && productID <= VenderMachine.GetProductList().Count) { break; }
                productID = VenderMachine.WantProduct();
            }


            return productID;
        }

        public static double WantCoin(product p, double totalCoin = 0, bool isProductSelected = false)
        {

            Console.WriteLine("Enter Coin : ");
            double newCoin = Convert.ToDouble(Console.ReadLine());

            while (!IsValidCoin(newCoin))
            {
                Console.WriteLine("Invalid Coin. Please endter valid coin as $0.05, $0.10, $0.25. ");
                newCoin = WantCoin(p, totalCoin, isProductSelected);
            }

            return newCoin;
        }

        public static void StartProcess(product p, double totalCoinValue, bool isProductSelected = false)
        {
            if (totalCoinValue < p.amount)
            {
                Console.WriteLine("Please insert " + (p.amount - totalCoinValue).ToString("0.00") +
                                ", Selected Product price is $" + p.amount + ". Thank you.");

                double newCoin = WantCoin(p, totalCoinValue, isProductSelected);
                StartProcess(p, (totalCoinValue + newCoin), isProductSelected);
            }

            if (totalCoinValue == p.amount) { Console.WriteLine("Please collect your Product. Thank you."); return; }
            if (totalCoinValue > p.amount) { Console.WriteLine("Please collect your Product and remaining amount will return in your wallet. Thank you."); return; }

            Console.ReadLine();
        }

        public static bool IsValidCoin(double coinValue)
        {
            bool isValid = false;
            //(nickels(1/20 $), dimes (1/10 $), and  quarters(1 / 4 $)) and reject invalid ones(pennies(1 / 100 $)).
            double[] validCoins = { 0.05, 0.10, 0.25 };

            foreach (var coin in validCoins)
            {
                if (coinValue == coin) { isValid = true; break; }
            }


            return isValid;
        }

        public static List<product> GetProductList() //  or index
        {
            //cola for $1.00, chips for $0.50, and candy for $0.65.

            List<product> products = new List<product>();
            product p = new product();
            p.ID = 1;
            p.Name = "cola";
            p.amount = 1.00;
            products.Add(p);

            p = new product();
            p.ID = 2;
            p.Name = "chips";
            p.amount = 0.50;
            products.Add(p);

            p = new product();
            p.ID = 3;
            p.Name = "candy";
            p.amount = 0.65;
            products.Add(p);


            return products;

        }

        public static product SelectProduct(int productID) //  or index
        {
            //cola for $1.00, chips for $0.50, and candy for $0.65.

            if (productID <= 0) { return null; }

            List<product> products = GetProductList();
            return products[productID - 1];

        }

        public static void ShowProductList() //  or index
        {
            List<product> products = GetProductList();

            Console.WriteLine("\n.");
            Console.WriteLine("Please select product by Product ID...");

            foreach (var p in products)
            {
                Console.WriteLine("ProductID : " + p.ID + ", Name : " + p.Name + ", Price : " + p.amount.ToString("0.00"));
            }

            Console.WriteLine("\n\n.");
            Console.WriteLine("Select product ::  ");

        }
    }

    public class product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double amount { get; set; }
    }

}
