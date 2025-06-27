var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("Fusion");

builder.Services
  .AddFusionGatewayServer()
  .ConfigureFromFile("gateway.fgp")

  // Note: AllowQueryPlan is enabled for demonstration purposes. Disable in production environments.
  .ModifyFusionOptions(x => x.AllowQueryPlan = true);

builder.AddServiceDefaults();

var app = builder.Build();

const string graphQlPath = "/graphql";
app.MapGraphQL(graphQlPath);
app.MapGetRedirect(graphQlPath);

app.Run();
