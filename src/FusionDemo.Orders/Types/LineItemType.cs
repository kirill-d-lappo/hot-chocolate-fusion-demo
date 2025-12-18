namespace FusionDemo.Orders.Types;

[ObjectType<LineItem>]
public static partial class LineItemType
{
  static partial void Configure(IObjectTypeDescriptor<LineItem> descriptor)
  {
    descriptor.Ignore(x => x.ProductId);
  }

  public static Product Product([Parent] LineItem lineItem)
  {
    return new Product(lineItem.ProductId);
  }
}
