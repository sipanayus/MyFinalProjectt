﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //veritabanımda girilen ürünün karşılığı "_products"
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
              new Product{ProductId=1, CategoryId=1, ProductName="bardak", UnitPrice=15, UnitsInStock=15},
              new Product{ProductId=2, CategoryId=1, ProductName="kamera", UnitPrice=500, UnitsInStock=3},
              new Product{ProductId=3, CategoryId=2, ProductName="telefon", UnitPrice=1500, UnitsInStock=2},
              new Product{ProductId=4, CategoryId=2, ProductName="klavye", UnitPrice=150, UnitsInStock=65},
              new Product{ProductId=1, CategoryId=1, ProductName="fare", UnitPrice=85, UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        { //gönderdiğim ürün ıd'sine sahip listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
