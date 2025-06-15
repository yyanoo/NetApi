using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CardController : ControllerBase
{
    private readonly MongoService _mongoService;

    public CardController(MongoService mongoService)
    {
        _mongoService = mongoService;
    }

    [HttpGet("{collectionName}")]
    public async Task<IActionResult> Get(string collectionName)
    {
        var cards = await _mongoService.GetCardDataAsync(collectionName);
        return Ok(cards);
    }
}