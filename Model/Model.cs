using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Card
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? IdFromMongo { get; set; }

    [BsonElement("id")]
    public string? Id { get; set; }

    [BsonElement("name")]
    public string? Name { get; set; }

    [BsonElement("picture")]
    public string? Picture { get; set; }

    [BsonElement("color")]
    public string? Color { get; set; }

    [BsonElement("lvl")]
    public string? Lvl { get; set; }

    [BsonElement("cost")]
    public string? Cost { get; set; }

    [BsonElement("atk")]
    public string? Atk { get; set; }

    [BsonElement("soul")]
    public string? Soul { get; set; }

    [BsonElement("effect")]
    public List<string>? Effect { get; set; }
}