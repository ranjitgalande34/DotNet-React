using System;
namespace Ass4
{
	public class Product
    {

        private static string brand = "MyBrand";
        private static int lastPcode = 0;
        public int Pcode { get; private set; }
        public string Pname { get; set; }
        public int QtyInStock { get; set; }
        public double Price { get; set; }

        public Product(string pname, int qtyInStock, double price)
        {
            this.Pcode = ++lastPcode;
            this.Pname = pname;
            this.QtyInStock = qtyInStock;
            this.Price = price;
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"Pcode: {Pcode}, Pname: {Pname}, QtyInStock: {QtyInStock}, Price: {Price}, Brand: {brand}");
        }
    }
}

