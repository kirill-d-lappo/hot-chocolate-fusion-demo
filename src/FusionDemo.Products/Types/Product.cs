using HotChocolate.Fusion.SourceSchema.Types;

namespace FusionDemo.Products.Types;

public record Product
{
    public int Id { get; init; }

    public string Name { get; init; }

    public string Sku { get; init; }

    public string Description { get; init; }

    public decimal Price { get; init; }
}

public static class ProductOperations
{
    [Query]
    [Lookup]
    [Internal]
    public static Product GetProductById(int id)
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