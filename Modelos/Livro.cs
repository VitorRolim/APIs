using System.Text.Json.Serialization;

namespace ClassesAPIs.Modelos;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string Autor { get; set; }
    [JsonPropertyName("ano_publicacao")]
    public int AnoPublicacao { get; set; }
    [JsonPropertyName("genero")]
    public string Genero { get; set; }
    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }

    public string LivroDesc => $"O autor {Autor} fez o livro {Titulo} cujo o gênero é {Genero}, foi publicado em{AnoPublicacao} e tem {Paginas} páginas";
}
