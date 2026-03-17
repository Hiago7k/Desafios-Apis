using System.Text.Json.Serialization;

namespace Desafios_Apis.Modelos;

internal class Filmes
{
    [JsonPropertyName("title")]
    public string NomeDoFilme { get; set; }
    [JsonPropertyName("year")]
    public int AnoDoFilme { get; set; }
    [JsonPropertyName("crew")]
    public string Equipe { get; set; }
    [JsonPropertyName("rank")]
    public int Rank { get; set; }
}
