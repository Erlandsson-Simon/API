using RestSharp;
using System.Text.Json;
using System.Net;

RestClient starWarsClient = new("https://swapi.py4e.com/api/");
RestRequest request = new("people/4/");
RestResponse response = starWarsClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    Info p = JsonSerializer.Deserialize<Info>(response.Content);

    Console.WriteLine("Name: " + p.name);
    Console.WriteLine("Birth Year: " + p.birth_year);
    Console.WriteLine("Eye Color: " + p.eye_color);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Error");
}
//Console.WriteLine(response.Content);

Console.ReadLine();
