using Inlamning_4_API;
using System.Text.Json;


using HttpClient client = new()
{
    BaseAddress = new Uri("https://api.github.com/orgs/dotnet/"),
    DefaultRequestHeaders = { { "User-Agent", "ConsoleApp" } }
};

var repos = await GetPostsAsync(client);

foreach (var r in repos)
{
    Console.WriteLine(r + "\n");
}




static async Task<List<Repo>> GetPostsAsync(HttpClient client)
{

    await using Stream stream = await client.GetStreamAsync("repos");
    var result = await JsonSerializer.DeserializeAsync<List<Repo>>(stream);

    return result ?? new();
}
