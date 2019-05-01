using System;
using System.Collections.Generic;
using BullSheepFood.Data.Repositories.Abstractions;
using BullSheepFood.Data.Services.Abstractions;
using BullSheepFood.Models;

namespace BullSheepFood.Data.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product Create(Product entity)
        {
            var newAffiliate = _productRepository.Create(entity);
            return newAffiliate;
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product Update(Product entity)
        {
            return _productRepository.Update(entity);
        }

        public Product Delete(int id)
        {
            var item = _productRepository.GetById(id);

            if (item == null) throw new ArgumentException();
            _productRepository.Remove(item);
            return item;
        }
    }
}
