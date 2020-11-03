using HotChocolate;
using hotchocolatedemo.Data;
using System.Linq;

namespace hotchocolatedemo.Graph
{
    public class Query
    {
        public IQueryable<Manufacturer> GetManufacturers([Service] ApplicationDbContext context) => context.Manufacturers;
        public IQueryable<Product> GetProducts([Service] ApplicationDbContext context) => context.Products;
    }
}