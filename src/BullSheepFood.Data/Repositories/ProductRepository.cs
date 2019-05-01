using System;
using System.Linq;
using BullSheepFood.Data.Repositories.Abstractions;
using BullSheepFood.Models;
using Microsoft.EntityFrameworkCore;

namespace BullSheepFood.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly BullSheepDbContext _dbContext;
        private readonly DbSet<Product> _dbSet;

        public ProductRepository(BullSheepDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet= _dbContext.Set<Product>();
        }

        public Product Create(Product item)
        {
            _dbSet.Add(item);
            _dbContext.SaveChanges();

            return item;
        }

        public Product GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<Product> GetAll()
        {
            return _dbSet;
        }

        public void Remove(Product item)
        {
            _dbSet.Remove(item);
            _dbContext.SaveChanges();
        }

        public Product Update(Product item)
        {
            _dbSet.Update(item);
            _dbContext.SaveChanges();

            return item;
        }
    }
}
