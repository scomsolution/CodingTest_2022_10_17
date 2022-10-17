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




            #region PREVIOUS DAY CODE

            //public static void WantProduct()
            //{
            //    Console.WriteLine("Select Product : ");
            //    int productID = Convert.ToInt32(Console.ReadLine());

            //    if (productIDorIndex > 0 || productIDorIndex <= GetProductList().Count)
            //    { isProductSelected = true; productIDorIndex = productID; }
            //    else {   WantProduct(); }
            //}

            //public static void WantCoin()
            //{

            //    Console.WriteLine("Enter Coin : ");
            //    double newCoin = Convert.ToDouble(Console.ReadLine());

            //    if (!IsValidCoin(newCoin)) { Console.WriteLine("Invalid Coin. Please endter valid coin as $0.05, $0.10, $0.25. "); WantCoin(); return; }
            //    else { totalCoin = totalCoin + newCoin; }

            //    if (isProductSelected) { StartProcess(p, totalCoin); }

            //}


            //public static void StartProcess(product p, double totalCoinValue)
            //{
            //    if (totalCoinValue < p.amount)
            //    {
            //        Console.WriteLine("Please insert " + (p.amount - totalCoinValue).ToString("0.00") +
            //                        ", Selected Product price is $" + p.amount + ". Thank you.");

            //        WantCoin();
            //    }

            //    if (totalCoinValue == p.amount) { Console.WriteLine("Please collect your Product. Thank you."); return; }
            //    if (totalCoinValue > p.amount) { Console.WriteLine("Please collect your Product and remaining amount will return in your wallet. Thank you."); return; }

            //    Console.ReadLine();
            //}


            //public static bool IsValidCoin(double coinValue)
            //{
            //    bool isValid = false;
            //    //(nickels(1/20 $), dimes (1/10 $), and  quarters(1 / 4 $)) and reject invalid ones(pennies(1 / 100 $)).
            //    double[] validCoins = { 0.05, 0.10, 0.25 };

            //    foreach (var coin in validCoins)
            //    {
            //        if (coinValue == coin) { isValid = true; break; }
            //    }


            //    return isValid;
            //}

            //public static List<product> GetProductList() //  or index
            //{
            //    //cola for $1.00, chips for $0.50, and candy for $0.65.

            //    List<product> products = new List<product>();
            //    product p = new product();
            //    p.ID = 1;
            //    p.Name = "cola";
            //    p.amount = 1.00;
            //    products.Add(p);

            //    p = new product();
            //    p.ID = 2;
            //    p.Name = "chips";
            //    p.amount = 0.50;
            //    products.Add(p);

            //    p = new product();
            //    p.ID = 3;
            //    p.Name = "candy";
            //    p.amount = 0.65;
            //    products.Add(p);


            //    return products;

            //}

            //public static product SelectProduct(int productID) //  or index
            //{
            //    //cola for $1.00, chips for $0.50, and candy for $0.65.

            //    List<product> products = GetProductList();
            //    return products[productID - 1];

            //}

            //public static void ShowProductList() //  or index
            //{
            //    List<product> products = GetProductList();

            //    Console.WriteLine("\n.");
            //    Console.WriteLine("Please select product by Product ID...");

            //    foreach (var p in products)
            //    {
            //        Console.WriteLine("ProductID : " + p.ID + ", Name : " + p.Name + ", Price : " + p.amount.ToString("0.00"));
            //    }

            //    Console.WriteLine("\n\n.");
            //    Console.WriteLine("Select product ::  ");

            //}

            #endregion
        }
    }
}





#region  OLD CODE

//class Program
//{
//    public Program()
//    {
//    }

//    static double totalCoin = 0;
//    static product p = new product();
//    static bool isProductSelected = false;
//    static int productIDorIndex = -1;
//    static void Main(string[] args)
//    {
//        WantCoin();


//        ShowProductList();

//        WantProduct();


//        p = SelectProduct(productIDorIndex);
//        Console.WriteLine("Selected Product  is: " + p.Name);

//        StartProcess(p, totalCoin);


//    }

//    public static void WantProduct()
//    {
//        Console.WriteLine("Select Product : ");
//        int productID = Convert.ToInt32(Console.ReadLine());

//        if (productIDorIndex > 0 || productIDorIndex <= GetProductList().Count)
//        { isProductSelected = true; productIDorIndex = productID; }
//        else { WantProduct(); }
//    }

//    public static void WantCoin()
//    {

//        Console.WriteLine("Enter Coin : ");
//        double newCoin = Convert.ToDouble(Console.ReadLine());

//        if (!IsValidCoin(newCoin)) { Console.WriteLine("Invalid Coin. Please endter valid coin as $0.05, $0.10, $0.25. "); WantCoin(); return; }
//        else { totalCoin = totalCoin + newCoin; }

//        if (isProductSelected) { StartProcess(p, totalCoin); }

//    }


//    public static void StartProcess(product p, double totalCoinValue)
//    {
//        if (totalCoinValue < p.amount)
//        {
//            Console.WriteLine("Please insert " + (p.amount - totalCoinValue).ToString("0.00") +
//                            ", Selected Product price is $" + p.amount + ". Thank you.");

//            WantCoin();
//        }

//        if (totalCoinValue == p.amount) { Console.WriteLine("Please collect your Product. Thank you."); return; }
//        if (totalCoinValue > p.amount) { Console.WriteLine("Please collect your Product and remaining amount will return in your wallet. Thank you."); return; }

//        Console.ReadLine();
//    }


//    public static bool IsValidCoin(double coinValue)
//    {
//        bool isValid = false;
//        //(nickels(1/20 $), dimes (1/10 $), and  quarters(1 / 4 $)) and reject invalid ones(pennies(1 / 100 $)).
//        double[] validCoins = { 0.05, 0.10, 0.25 };

//        foreach (var coin in validCoins)
//        {
//            if (coinValue == coin) { isValid = true; break; }
//        }


//        return isValid;
//    }

//    public static List<product> GetProductList() //  or index
//    {
//        //cola for $1.00, chips for $0.50, and candy for $0.65.

//        List<product> products = new List<product>();
//        product p = new product();
//        p.ID = 1;
//        p.Name = "cola";
//        p.amount = 1.00;
//        products.Add(p);

//        p = new product();
//        p.ID = 2;
//        p.Name = "chips";
//        p.amount = 0.50;
//        products.Add(p);

//        p = new product();
//        p.ID = 3;
//        p.Name = "candy";
//        p.amount = 0.65;
//        products.Add(p);


//        return products;

//    }

//    public static product SelectProduct(int productID) //  or index
//    {
//        //cola for $1.00, chips for $0.50, and candy for $0.65.

//        List<product> products = GetProductList();
//        return products[productID - 1];

//    }

//    public static void ShowProductList() //  or index
//    {
//        List<product> products = GetProductList();

//        Console.WriteLine("\n.");
//        Console.WriteLine("Please select product by Product ID...");

//        foreach (var p in products)
//        {
//            Console.WriteLine("ProductID : " + p.ID + ", Name : " + p.Name + ", Price : " + p.amount.ToString("0.00"));
//        }

//        Console.WriteLine("\n\n.");
//        Console.WriteLine("Select product ::  ");

//    }
//}


#endregion 

