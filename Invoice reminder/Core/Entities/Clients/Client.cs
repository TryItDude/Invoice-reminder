using Invoice_reminder.Core.Abstractions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Invoice_reminder.Core.Entities.Clients;

public sealed class Client : Entity
{
    public Client(
        Guid id,
        Name name,
        Address address,
        DocumentType documentType,
        DocumentNumber documentNumber,
        PhoneNumber phoneNumber
        ) : base(id)
    {
        Name = name;
        Address = address;
        DocumentType = documentType;
        DocumentNumber = documentNumber;
        PhoneNumber = phoneNumber;
    }
    [BsonElement("name")]
    public Name? Name { get; private set; }
    [BsonElement("address")]

    public Address? Address { get; private set; }
    [BsonElement("documentType")]

    public DocumentType? DocumentType { get; private set; }
    [BsonElement("documentNumber")]
    public DocumentNumber? DocumentNumber { get; private set; }
    [BsonElement("phoneNumber")]
    public PhoneNumber? PhoneNumber { get; private set; }

    private Client() { }

    public static Client Create(
        Name name,
        Address address,
        DocumentType documentType,
        DocumentNumber documentNumber,
        PhoneNumber phoneNumber
        )
    {
        var client = new Client(Guid.NewGuid(), name, address, documentType, documentNumber, phoneNumber);
        return client;
    }

}

