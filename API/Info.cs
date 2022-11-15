using System.Text.Json.Serialization;

public class Info
{
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("birth_year")]
    public string birth_year { get; set; }

    [JsonPropertyName("eye_color")]
    public string eye_color { get; set; }


    public bool is_default { get; set; }
}
