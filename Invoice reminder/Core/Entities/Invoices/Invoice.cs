using Invoice_reminder.Core.Abstractions;

namespace Invoice_reminder.Core.Entities.Invoices;
public class Invoice : Entity
{

    private Invoice(
        Guid clientID,
        Money totalAmount,
        Money subTotal,
        Taxes tax,
        Money retention,
        DateTime creationDate,
        InvoiceStatus status,
        bool isPaid,
        DateTime? paymentDate)
    {
        ClientID = clientID;
        TotalAmount = totalAmount;
        SubTotal = subTotal;
        Tax = tax;
        Retention = retention;
        CreationDate = creationDate;
        Status = status;
        IsPaid = isPaid;
        PaymentDate = paymentDate;
    }

    public Guid ClientID { get; private set; }
    public Money? TotalAmount { get; private set; }
    public Money? SubTotal { get; private set; }
    public Taxes? Tax { get; private set; }
    public Money? Retention { get; private set; }
    public DateTime CreationDate { get; private set; }
    public InvoiceStatus? Status { get; private set; }
    public bool IsPaid { get; private set; }
    public DateTime? PaymentDate { get; private set; }

    private Invoice() { }

}


