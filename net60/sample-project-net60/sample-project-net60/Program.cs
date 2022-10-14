using GraphQL.AspNet.Configuration.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGraphQL();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseGraphQL();

app.Run();
