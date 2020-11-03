using hotchocolatedemo.Data;

namespace hotchocolatedemo.Graph
{
    public class AddManufacturerPayload
    {
        public Manufacturer Manufacturer { get; }
        public AddManufacturerPayload(Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
        }
    }

    public class AddProductPayload
    {
        public Product Product { get; }
        public AddProductPayload(Product product)
        {
            Product = product;
        }
    }
}