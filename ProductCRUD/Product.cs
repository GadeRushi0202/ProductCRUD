using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    public class Product
    {
        public int ID { get ; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }
    }
    public class ProductCRUD
    {
        private List<Product> productlist;
        public ProductCRUD()
        {
            productlist = new List<Product>()
            {
                new Product() { ID = 1, Name="Laptop",Price=35000,Company="Hp"},
                 new Product() { ID = 2, Name="Laptop",Price=45000,Company="Dell"}
            }; 
        }
        //Displa List
        public List<Product>GetProducts()
        {
            return productlist;
        }

        //Get Single Product

        public Product GetProductBYID(int ID)
        {
            //search for id in the collection
            Product product = new Product();
            foreach(Product p in productlist)
            {
                if(p.ID == ID)
                {
                    product=p;
                    break;
                }
            }
            return product;
        }
        //Add New Product
        public void AddProduct(Product p)
        {
            productlist.Add(p);
        }
        //Modify the Product
        public void UpdateProduct(Product p)
        {
            foreach(Product item  in productlist)
            {
                if(item.ID == p.ID)
                {
                    item.Name = p.Name;
                    item.Price = p.Price;
                    item.Company = p.Company;
                    break;
                }
            }
        }
        //Remove the Product
        public void DeleteProduct(int ID)
        {
            foreach (Product item in productlist)
            {
                if(item.ID == ID)
                {
                    productlist.Remove(item);
                    break;
                }
            }
        }
       
    }
}
