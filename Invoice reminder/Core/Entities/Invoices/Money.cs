namespace Invoice_reminder.Core.Entities.Invoices;
public record Money(decimal Aumout, Currency Currency)
{
    public static Money operator +(Money first, Money second)
    {
        if (first.Currency != second.Currency)
        {
            throw new ArgumentException("Currencies have to be equal");
        }
        return new Money(first.Aumout + second.Aumout, first.Currency);
    }

    public static Money Zero() => new Money(0, Currency.None);
}


