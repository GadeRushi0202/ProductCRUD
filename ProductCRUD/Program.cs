using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            ProductCRUD crud = new ProductCRUD();
            do
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine("1.Product List");
                Console.WriteLine("2.Get Product By ID");
                Console.WriteLine("3.Add Product");
                Console.WriteLine("4.Update Product");
                Console.WriteLine("5.Delete Product");
                Console.WriteLine("Select Your Option");

                int option =Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Product> list = crud.GetProducts();
                        Console.WriteLine("Id \t Name \t Price \t Company");
                        foreach(Product product in list)
                        {
                            Console.WriteLine($"{product.ID} \t {product.Name} \t {product.Price} \t {product.Company}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Product Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p =crud.GetProductBYID(id);
                        Console.WriteLine("Id \t Name \t Price \t Company");
                        Console.WriteLine($"{p.ID} \t {p.Name} \t {p.Price} \t {p.Company}");
                        break;
                    case 3:
                        Product p1 = new Product();
                        Console.WriteLine("Enter Product Id");
                        p1.ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p1.Name= Console.ReadLine();
                        Console.WriteLine("Enter The Price ");
                        p1.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Company  Name");
                        p1.Company = Console.ReadLine();
                        crud.AddProduct(p1);
                        Console.WriteLine("Produc Saved");
                        break;
                    case 4:
                        Product p2 = new Product();
                        Console.WriteLine("Enter Product Id");
                        p2.ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter The Price ");
                        p2.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Company  Name");
                        p2.Company = Console.ReadLine();
                        crud.UpdateProduct(p2);
                        Console.WriteLine("Product Update");
                        break;
                    case 5:
                        Console.WriteLine("Enter The Product Id");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(ID);
                        Console.WriteLine($"{ID}  Product Deleted.. ");
                        break;
                }
                Console.WriteLine("Press 1 for Continue");
                no = Convert.ToInt32(Console.ReadLine());  
            }
            while (no != 0);
        }
    }
}
