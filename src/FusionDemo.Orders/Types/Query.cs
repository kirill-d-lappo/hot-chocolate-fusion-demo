namespace FusionDemo.Orders.Types;

[QueryType]
public static class Query
{
  public static Order[] AllOrders()
  {
    return
    [
      new Order
      {
        Id = 1,
        Name = "Order 1",
        Description = "Description 1",
        Items =
        [
          new LineItem
          {
            Id = 1, Quantity = 1, ProductId = 1,
          },
          new LineItem
          {
            Id = 2, Quantity = 2, ProductId = 2,
          },
        ],
      },
      new Order
      {
        Id = 2,
        Name = "Order 2",
        Description = "Description 2",
        Items =
        [
          new LineItem
          {
            Id = 3, Quantity = 3, ProductId = 3,
          },
          new LineItem
          {
            Id = 4, Quantity = 4, ProductId = 4,
          },
        ],
      },
    ];
  }
}
