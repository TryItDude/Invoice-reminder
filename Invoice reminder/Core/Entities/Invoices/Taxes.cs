namespace Invoice_reminder.Core.Entities.Invoices;
public sealed record Taxes
{
    public decimal Value { get; }
    private Taxes(decimal value)
    {
        if (value is < 0 or > 100)
        {
            throw new ArgumentException(nameof(value), "The taxes value must be between 0 and 100");
        }
        Value = value;
    }

    public static Taxes FromValue(decimal value) { return new Taxes(value); }
}

