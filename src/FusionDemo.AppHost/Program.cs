var builder = DistributedApplication.CreateBuilder(args);

var orders = builder.AddProject<Projects.FusionDemo_Orders>("orders");
var products = builder.AddProject<Projects.FusionDemo_Products>("products");

builder
  .AddFusionGateway<Projects.FusionDemo_Gateway>("gateway")
  .WithSubgraph(orders)
  .WithSubgraph(products);

builder.Build()
  .Compose()
  .Run();
