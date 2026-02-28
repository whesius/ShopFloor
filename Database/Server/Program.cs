using Allors.Database;
using Allors.Database.Adapters;
using Allors.Database.Configuration;
using Allors.Database.Configuration.Derivations.Default;
using Allors.Database.Domain;
using Allors.Database.Meta;
using Allors.Database.Meta.Configuration;
using Allors.Configuration;
using Allors.Services;
using Microsoft.AspNetCore.Components.Server.Circuits;
using ObjectFactory = Allors.Database.ObjectFactory;
using User = Allors.Database.Domain.User;

var builder = WebApplication.CreateBuilder(args);

// Build Allors meta
var metaPopulation = new MetaBuilder().Build();
var engine = new Engine(Rules.Create(metaPopulation));
var objectFactory = new ObjectFactory(metaPopulation, typeof(User));

// Build database (Npgsql/PostgreSQL)
var databaseBuilder = new DatabaseBuilder(
    new DefaultDatabaseServices(engine),
    builder.Configuration,
    objectFactory);
var database = databaseBuilder.Build();

// Register Allors services
builder.Services.AddSingleton<IDatabase>(database);
builder.Services.AddSingleton<IDatabaseService>(new DatabaseService(database));
builder.Services.AddScoped<ITransactionService, TransactionService>();

// Add Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<Server.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
