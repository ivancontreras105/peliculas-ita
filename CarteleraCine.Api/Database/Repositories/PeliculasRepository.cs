using CarteleraCine.Api.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CarteleraCine.Api.Database.Repositories;

public class PeliculasRepository : Repository
{
    public PeliculasRepository(IOptions<MongoDbOptions> options, DatabaseContext dbContext, IMongoClient mongoClient) : base(options, dbContext, mongoClient)
    {
    }

    public async Task<List<Pelicula>> List()
    {
        var lista = await this.dbContext.Peliculas.ToListAsync();
        return lista;
    }
}