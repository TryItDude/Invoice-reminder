using Invoice_reminder.Core.Entities.Clients;
using Invoice_reminder.Core.Entities.Interfaces;
using Invoice_reminder.Infraestructure.Database;
using MongoDB.Driver;

namespace Invoice_reminder.Infraestructure.Repositories;
public class ClientRepository : IClientRepository
{

    private readonly AppDbContext _dbContext;
    private readonly IMongoCollection<Client> _clients;

    public ClientRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _clients = _dbContext.Database!.GetCollection<Client>("Clients");
    }

    public void Add(Client client)
    {
        _clients.InsertOne(client);
    }

    public void Delete(Client client)
    {
        _clients.DeleteOne(c => c.Id == client.Id);
    }
    public void Update(Client client)
    {
        _clients.ReplaceOne(c => c.Id == client.Id, client);
    }

    public async Task<List<Client>> GetAllAsync()
    {
        return await _clients.Find(c => true).ToListAsync();
    }

    public async Task<Client> GetByIdAsync(Guid id)
    {
        return await _clients.Find(c => c.Id == id).FirstOrDefaultAsync();
    }


}

