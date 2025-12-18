using HotChocolate.Fusion.SourceSchema.Types;

namespace FusionDemo.Products.Types;

public static class ProductOperations
{
  [Query]
  [Lookup]
  [Internal]
  public static Product ProductById(int id)
  {
    // Replace with actual data retrieval logic
    return new Product
    {
      Id = id,
      Name = $"Product {id}",
      Sku = $"SKU{id}",
      Description = $"Description {id}",
      Price = id,
    };
  }
}
