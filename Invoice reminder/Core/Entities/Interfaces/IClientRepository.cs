using Invoice_reminder.Core.Entities.Clients;

namespace Invoice_reminder.Core.Entities.Interfaces;

public interface IClientRepository
{
    Task<Client> GetByIdAsync(Guid id);
    Task<List<Client>> GetAllAsync();
    void Add(Client client);
    void Update(Client client);
    void Delete(Client client);
}
