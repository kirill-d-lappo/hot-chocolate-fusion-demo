var builder = WebApplication.CreateBuilder(args);

builder.AddGraphQL().AddFusionDemoProductsTypes();

builder.AddServiceDefaults();

var app = builder.Build();

const string graphQlPath = "/graphql";
app.MapGraphQL(graphQlPath);
app.MapGetRedirect(graphQlPath);

app.RunWithGraphQLCommands(args);