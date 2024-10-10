using ClassesAPIs.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filmes>>(resposta);

        foreach (var filme in filmes)
        {
            Console.WriteLine(filme.FichaTecnica);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Vixe deu o erro: {ex.Message}");
    }
}

Console.WriteLine("\n--------------------------------API PAÍSES--------------------------------");
using(HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);

        foreach(var pais in paises)
        {
            Console.WriteLine(pais.DescricaoPais);
        }

    }
    catch(Exception ex) 
    {
        Console.WriteLine($"Pane no sistema: {ex.Message}");
    }
}

Console.WriteLine("\n-------------------------API CARROS-------------------------");
using(HttpClient client2 = new HttpClient())
{
    try
    {
        string resposta = await client2.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);

        foreach (var carro in carros)
        {
            Console.WriteLine(carro.Marca);
        }
    }catch(Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

Console.WriteLine("\n-------------------------API LIVROS-------------------------");

using( HttpClient client3 = new HttpClient())
{
    try
    {
        string respota = await client3.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(respota);

        foreach(var livro in livros)
        {
            Console.WriteLine($"\nTitulo: {livro.Titulo}");
            Console.WriteLine($"\nAutor: {livro.Autor}");
        }
    }
    catch( Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}
