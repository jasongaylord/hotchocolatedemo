using HotChocolate;
using hotchocolatedemo.Data;
using System.Linq;

namespace hotchocolatedemo.Graph
{
    public class Query
    {
        public IQueryable<Product> GetProducts([Service] ApplicationDbContext context) => context.Products;
    }
}