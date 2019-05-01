using System.Linq;
using BullSheepFood.Models;

namespace BullSheepFood.Data.Repositories.Abstractions
{
    public interface IProductRepository
    {
        Product Create(Product item);
        Product GetById(int id);
        IQueryable<Product> GetAll();
        void Remove(Product item);
        Product Update(Product item);
    }
}
