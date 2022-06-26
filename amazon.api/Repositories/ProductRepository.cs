using amazon.api.Entities;
using amazon.api.Repositories.Contracts;

namespace amazon.api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<ProductCategory>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItems()
        {

        }
    }
}
