using HotChocolate;
using hotchocolatedemo.Data;
using System.Threading;
using System.Threading.Tasks;

namespace hotchocolatedemo.Graph
{
    public class Mutation
    {
        public async Task<AddManufacturerPayload> AddManufacturerAsync(AddManufacturerInput input, [Service]ApplicationDbContext context, CancellationToken cancellationToken)
        {
            var manufacturer = new Manufacturer { Name = input.Name };
            context.Manufacturers.Add(manufacturer);
            await context.SaveChangesAsync();
            return new AddManufacturerPayload(manufacturer);
        }

        public async Task<AddProductPayload> AddProductAsync(AddProductInput input, [Service]ApplicationDbContext context, CancellationToken cancellationToken)
        {
            Manufacturer? manufacturer = await context.Manufacturers.FindAsync(input.ManufacturerId);
            var product = new Product { Name = input.Name, Price = input.Price, LastUpdated = input.LastUpdated, PrimaryManufacturer = manufacturer };
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return new AddProductPayload(product);
        }
    }
}