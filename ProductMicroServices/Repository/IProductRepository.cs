﻿using ProductMicroServices.Models;

namespace ProductMicroServices.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int ProductId);    
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int ProductId);
        void Save();
    }
}
