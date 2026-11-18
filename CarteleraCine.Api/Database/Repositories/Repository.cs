using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CarteleraCine.Api.Database.Repositories;

public abstract class Repository
{
    protected readonly DatabaseContext dbContext;
    protected readonly IMongoDatabase mongoDatabase;

    public Repository(IOptions<MongoDbOptions> options, DatabaseContext dbContext, IMongoClient mongoClient)
    {
        this.dbContext = dbContext;
        this.mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);
    }
}