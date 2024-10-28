using Invoice_reminder.Core.Entities.Clients;
using MongoDB.Bson.Serialization;

namespace Invoice_reminder.Infraestructure.Database.Configurations;

public static class ClientConfiguration
{
    public static void Configure()
    {
        if (!BsonClassMap.IsClassMapRegistered(typeof(Client)))
        {
            BsonClassMap.RegisterClassMap<Client>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty(c => c.Id).SetElementName("id");
                cm.MapProperty(c => c.Name).SetElementName("name");
                cm.MapProperty(c => c.Address).SetElementName("address");
                cm.MapProperty(c => c.DocumentType).SetElementName("documentType");
                cm.MapProperty(c => c.DocumentNumber).SetElementName("documentNumber");
                cm.MapProperty(c => c.PhoneNumber).SetElementName("phoneNumber");
            });
        }
    }
}
