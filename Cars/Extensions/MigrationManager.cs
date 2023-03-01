using Cars.Migrations;
using FluentMigrator.Runner;

namespace Cars.Extensions;

public static class MigrationManager
{
    public static IHost MigrateDatabase(this IHost host)
    {
        using var scope = host.Services.CreateScope();

        var databaseService = scope.ServiceProvider.GetRequiredService<Database>();
        var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

        try
        {
            databaseService.CreateDatabase("cars");
            migrationService.ListMigrations();
            migrationService.MigrateUp();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        return host;
    }
}