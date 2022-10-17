using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Program
    {
        static double totalCoin = 0;
        static product p = new product();
        static bool isProductSelected = false;
        static int productIDorIndex = -1;

        static void Main(string[] args)
        {
            double newCoin = VenderMachine.WantCoin(p);
            totalCoin = totalCoin + newCoin;
            newCoin = 0;

            VenderMachine.ShowProductList();

            productIDorIndex = VenderMachine.WantProduct();



            p = VenderMachine.SelectProduct(productIDorIndex);
            Console.WriteLine("Selected Product  is: " + p.Name);
            Console.WriteLine("\n\n");

            if (p.Name != null) { isProductSelected = true; }

            VenderMachine.StartProcess(p, totalCoin, isProductSelected);


            totalCoin = totalCoin + newCoin;

            if (isProductSelected) { VenderMachine.StartProcess(p, totalCoin); }

        }
    }
}
