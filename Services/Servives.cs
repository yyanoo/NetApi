using MongoDB.Driver;

public class MongoService
{
    private readonly MongoClient _client;

    public MongoService(IConfiguration configuration)
    {
        var connectionString = configuration["MongoDb:ConnectionString"];
        _client = new MongoClient(connectionString);
    }

    public async Task<List<Card>> GetCardDataAsync(string collectionName)
    {
        var database = _client.GetDatabase("card");
        var collection = database.GetCollection<Card>(collectionName);
        var result = await collection.Find(_ => true).ToListAsync();
        return result;
    }
}