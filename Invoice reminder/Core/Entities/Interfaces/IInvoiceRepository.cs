using Invoice_reminder.Core.Entities.Invoices;

namespace Invoice_reminder.Core.Entities.Interfaces;

    public interface IInvoiceRepository
{
    Task<Invoice> GetByIdAsync(Guid id);
    Task<List<Invoice>> GetAll();
    void Add(Invoice invoice);
    void Update(Invoice invoice);
    void Delete(Invoice invoice);
}
