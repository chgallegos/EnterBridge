using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

[ApiController]
[Route("api/proxy")]
public class ProxyController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public ProxyController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    [HttpGet("products")]
    public async Task<IActionResult> GetProducts()
    {
        var response = await _httpClient.GetAsync("https://api.casestudy.enterbridge.com/api/products?PageNumber=1&PageSize=100");

        if (!response.IsSuccessStatusCode)
        {
            return StatusCode((int)response.StatusCode, "Failed to fetch products");
        }

        var content = await response.Content.ReadAsStringAsync();
        var json = JObject.Parse(content);
        var items = json["items"];

        return Content(items.ToString(), "application/json");
    }

 [HttpGet("prices")]
public async Task<IActionResult> GetPrices([FromQuery] int productId)
{
    var response = await _httpClient.GetAsync($"https://api.casestudy.enterbridge.com/api/prices?productId={productId}");

    if (!response.IsSuccessStatusCode)
    {
        return StatusCode((int)response.StatusCode, "Failed to fetch prices");
    }

    var content = await response.Content.ReadAsStringAsync();
    return Content(content, "application/json");
}

}
