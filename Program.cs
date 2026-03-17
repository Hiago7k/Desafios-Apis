using (HttpClient httpClient = new HttpClient()) 
{

    try
    {
        string resposta = await httpClient.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao realizar requisicao na API {ex:Message}");
    }
}