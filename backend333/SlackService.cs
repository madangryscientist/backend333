using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace backend333;

public class SlackService
{
    private readonly HttpClient _httpClient;

    public SlackService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task PostAsync(SlackMessage msg)
    {
        var content = JsonConvert.SerializeObject(msg);
        var httpContent = new StringContent(
            content,
            Encoding.UTF8,
            "application/json"
        );
        var response = await _httpClient.PostAsync("chat.postMessage", httpContent);
        
    }
}

public class SlackMessage
{
    public string channel { get; set; }
    public string text { get; set; }
    public bool as_user { get; set; }
}