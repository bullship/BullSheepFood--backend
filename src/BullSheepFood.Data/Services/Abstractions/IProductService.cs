using System.Collections.Generic;
using BullSheepFood.Models;

namespace BullSheepFood.Data.Services.Abstractions
{
    public interface IProductService
    {
        Product GetById(int id);
        Product Create(Product entity);
        IEnumerable<Product> GetAll();
        Product Update(Product entity);
        Product Delete(int id);
    }
}
