var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://speaker-verification1.p.rapidapi.com/Verification"),
    Headers =
    {
        { "x-rapidapi-key", "API KEY" },
        { "x-rapidapi-host", "speaker-verification1.p.rapidapi.com" },
    },
    Content = new MultipartFormDataContent
    {
        new StringContent("")
        {
            Headers =
            {
                ContentType = new MediaTypeHeaderValue("application/octet-stream"),
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "sound1",
                }
            }
        },
        new StringContent("")
        {
            Headers =
            {
                ContentType = new MediaTypeHeaderValue("application/octet-stream"),
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "sound2",
                }
            }
        },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
