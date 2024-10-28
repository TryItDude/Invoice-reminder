namespace Invoice_reminder.Core.Entities.Clients;

public sealed record DocumentType(string Value)
{
    private static readonly DocumentType CC = new DocumentType("cc");
    private static readonly DocumentType NIT = new DocumentType("nit");

    public static DocumentType Create(string Value)
    {
        string lowerValue = Value.ToLower();
        return All.FirstOrDefault(c => c.Value == lowerValue)
            ?? throw new ApplicationException("The document type value is invalid");

    }

    public static readonly IReadOnlyCollection<DocumentType> All = new[]
    {
            CC,
            NIT
        };
}

