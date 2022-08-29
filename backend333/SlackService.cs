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
        _httpClient.BaseAddress = new Uri("https://slack.com/api/");

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "xoxb-3554094122145-3994457821397-zpxKyV4JnOZIda8goJ0toJob");
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