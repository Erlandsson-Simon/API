using RestSharp;
using System.Text.Json;
using System.Net;

RestClient jeopardyClient = new("https://jservice.io");
RestRequest request = new("/api/random");
RestResponse response = jeopardyClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
   // Info j = JsonSerializer.Deserialize<Info>(response.Content);

    Console.WriteLine(response.Content);
}
else
{
    Console.WriteLine("Error");
}
//Console.WriteLine(response.Content);

Console.ReadLine();
