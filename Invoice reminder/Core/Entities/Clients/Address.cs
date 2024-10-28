namespace Invoice_reminder.Core.Entities.Clients;

public sealed record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);

