using System.Text.Json.Serialization;

namespace Desafios_Apis.Modelos;

internal class Filmes
{
    [JsonPropertyName("title")]
    public string? NomeDoFilme { get; set; }
    [JsonPropertyName("year")]
    public string? AnoDoFilme { get; set; }
    [JsonPropertyName("crew")]
    public string? Equipe { get; set; }
    [JsonPropertyName("rank")]
    public string? Rank { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine("*****************");
        Console.WriteLine("Detalhes do Filme");
        Console.WriteLine($"\nNome do filme: {NomeDoFilme}");
        Console.WriteLine($"Ano de lancamento: {AnoDoFilme}");
        Console.WriteLine($"Elenco: {Equipe}");
        Console.WriteLine($"Posicao do rank: {Rank}");
        Console.WriteLine("*****************");

    }
}
