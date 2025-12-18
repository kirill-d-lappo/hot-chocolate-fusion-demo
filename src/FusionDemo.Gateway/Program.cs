var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("Fusion");

// Note: AllowQueryPlan is enabled for demonstration purposes. Disable in production environments
builder.Services
  .AddFusionGatewayServer()
  .ConfigureFromFile("gateway.fgp")
  .ModifyFusionOptions(x => x.AllowQueryPlan = true);

builder.AddServiceDefaults();

var app = builder.Build();

const string graphQlPath = "/graphql";
app.MapGraphQL(graphQlPath);
app.MapGetRedirect(graphQlPath);

app.Run();
