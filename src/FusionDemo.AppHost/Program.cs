var builder = DistributedApplication.CreateBuilder(args);

var ordering = builder.AddProject<Projects.FusionDemo_Ordering>("ordering");
var products = builder.AddProject<Projects.FusionDemo_Products>("products");

builder
    .AddFusionGateway<Projects.FusionDemo_Gateway>("gateway")
    .WithSubgraph(ordering)
    .WithSubgraph(products);

builder.Build().Compose().Run();