﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;
        public ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed Syrup", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };
        }
        public List<Product> GetProducts()
        {
            return listProducts;
        }
        public void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }
        public void UpdateProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    p.ProductId = product.ProductId;
                    p.ProductName = product.ProductName;
                    p.CategoryId = product.CategoryId;
                    p.UnitInStock = product.UnitInStock;
                    p.UnitPrice = product.UnitPrice;
                }
            }
        }
        public void DeleteProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    listProducts.Remove(p);
                    break; // Exit the loop after removing the product
                }
            }
        }
        public Product GetProductById(int id)
        {
            foreach (Product p in listProducts)
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}