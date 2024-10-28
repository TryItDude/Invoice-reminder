using Invoice_reminder.Core.Entities.Clients;

namespace Invoice_reminder.WebApi.Controllers.Clients;

public record PostClients(
        Name name,
        Address address,
        DocumentType documentType,
        DocumentNumber documentNumber,
        PhoneNumber phoneNumber)
{
}

