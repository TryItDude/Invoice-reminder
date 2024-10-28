using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Invoice_reminder.Core.Abstractions;

public class Entity
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }

    protected Entity(Guid id)
    {
        Id = id;
    }
    protected Entity() { }
}

