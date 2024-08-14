using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Ass4
{
        public class Program
        {
            private static List<Product> productList = new List<Product>();

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Who are you?");
                    Console.WriteLine("1. Admin");
                    Console.WriteLine("2. Customer");
                    Console.WriteLine("3. Exit");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        AdminActions();
                    }
                    else if (choice == "2")
                    {
                        CustomerActions();
                    }
                    else if (choice == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, please try again.");
                    }
                }
            }

            static void AdminActions()
            {
                Console.WriteLine("Admin Actions:");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display products");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddProduct();
                }
                else if (choice == "2")
                {
                    DisplayProducts();
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }

            static void AddProduct()
            {
                Console.Write("Enter product name: ");
                string pname = Console.ReadLine();
                Console.Write("Enter quantity in stock: ");
                int qtyInStock = int.Parse(Console.ReadLine());
 
                Console.Write("Enter price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(pname, qtyInStock, price);
                productList.Add(product);
                Console.WriteLine("Product added successfully.");
            }

            static void DisplayProducts()
            {
                Console.WriteLine("Product List:");
                foreach (Product product in productList)
                {
                    product.DisplayDetails();
                }
            }

            static void CustomerActions()
            {
                Console.WriteLine("Customer Actions:");
                Console.Write("Enter product name to purchase: ");
                string pname = Console.ReadLine();
                Product product = productList.Find(p => p.Pname.Equals(pname, StringComparison.OrdinalIgnoreCase));

                if (product != null)
                {
                    Console.WriteLine("Product Details:");
                    product.DisplayDetails();
                    Console.Write("Enter quantity to purchase: ");
                    int qtyToPurchase = int.Parse(Console.ReadLine());

                    if (qtyToPurchase <= product.QtyInStock)
                    {
                        double totalAmount = product.Price * qtyToPurchase;
                        double discountedAmount = totalAmount * 0.5; 
                        product.QtyInStock -= qtyToPurchase;
                        Console.WriteLine($"Total amount after discount: {discountedAmount}");
                        Console.WriteLine("Thank you for your purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient stock.");
                    }
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
        }
    }

