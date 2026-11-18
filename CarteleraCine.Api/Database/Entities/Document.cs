using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarteleraCine.Api.Database.Entities;

public abstract class Document
{
    [BsonId, BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
}