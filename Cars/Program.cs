using System.Reflection;
using Cars.DataAccess;
using Cars.DataAccess.IRepos;
using Cars.DataAccess.Repos;
using Cars.Extensions;
using Cars.Migrations;
using FluentMigrator.Runner;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<DapperContext>()
    .AddSingleton<Database>()
    .AddScoped<ICarBrandRepo, CarBrandRepo>()
    .AddScoped<ICarModelRepo, CarModelRepo>();

builder.Services.AddControllersWithViews();

builder.Services.AddLogging(c => c.AddFluentMigratorConsole())
    .AddFluentMigratorCore()
    .ConfigureRunner(c => c.AddPostgres()
        .WithGlobalConnectionString(builder.Configuration.GetConnectionString("PgConnection"))
        .ScanIn(Assembly.GetExecutingAssembly()).For.Migrations());

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CarBrand}/{action=Index}/{id?}");

app.MigrateDatabase();
app.Run();