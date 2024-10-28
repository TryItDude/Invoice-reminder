using Invoice_reminder.Core.Entities.Clients;
using MongoDB.Driver;

namespace Invoice_reminder.Infraestructure.Database;

public class AppDbContext
{
    private readonly IConfiguration _configuration;
    private readonly IMongoDatabase _database;
    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        if(connectionString == null)
        {
            throw new ArgumentNullException(nameof(connectionString));
        }
        var mongoUrl = MongoUrl.Create(connectionString);
        var mongoClient = new MongoClient(mongoUrl);
        _database = mongoClient.GetDatabase(mongoUrl.DatabaseName);
    }

    public IMongoDatabase? Database => _database;
    public IMongoCollection<Client> Clients => _database.GetCollection<Client>("Clients");
}

