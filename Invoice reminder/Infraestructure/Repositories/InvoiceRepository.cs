using Invoice_reminder.Core.Entities.Interfaces;
using Invoice_reminder.Core.Entities.Invoices;

namespace Invoice_reminder.Infraestructure.Repositories;
public class InvoiceRepository : IInvoiceRepository
{
    public void Add(Invoice invoice)
    {
        throw new NotImplementedException();
    }

    public void Delete(Invoice invoice)
    {
        throw new NotImplementedException();
    }

    public Task<List<Invoice>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Invoice> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Update(Invoice invoice)
    {
        throw new NotImplementedException();
    }
}

