using MongoDB.Driver;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CarteleraCine.Api.Database;

public static class MongoDbConfiguration
{
    public static void ConfigureMongoDb(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<MongoDbOptions>(configuration.GetSection("MongoDb"));

        services.AddSingleton<IMongoClient>(sp =>
        {
            var mongoOptions = sp
                .GetRequiredService<IOptions<MongoDbOptions>>()
                .Value;

            return new MongoClient(mongoOptions.ConnectionString);
        });

        services.AddDbContext<DatabaseContext>((sp, options) =>
        {
            var client = sp.GetRequiredService<IMongoClient>();

            var mongoOptions = sp
                .GetRequiredService<IOptions<MongoDbOptions>>()
                .Value;

            options.UseMongoDB(
                client,
                mongoOptions.DatabaseName
            );
        });
    }
}