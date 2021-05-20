using System;

namespace Customers
{
    class Program
    {
        static void Main(string[] args)
        {
            var custy1 = new Custy("TQL", "Cincinnati", "Ohio");
            var custy2 = new Custy("USB", "Stockton", "California");
            var custy3 = new Custy("HelloFresh", "Pittsburg", "Pennsylvania");

            custy1.AddSales(1000);
            custy1.AddSales(4000.50m); // to signal decimal m is placed after number
            Console.WriteLine($"Customer {custy1.Name} sales is {custy1.Sales}");

        }
    }
}
