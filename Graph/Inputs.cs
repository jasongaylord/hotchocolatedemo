using System;
using hotchocolatedemo.Data;
using HotChocolate.Types.Relay;

namespace hotchocolatedemo.Graph
{
    public record AddManufacturerInput(string Name);
    public record AddProductInput(string Name, float Price, DateTime LastUpdated, int ManufacturerId);
}