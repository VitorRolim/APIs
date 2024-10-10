using System.Text.Json.Serialization;

namespace ClassesAPIs.Modelos;

internal class Filmes
{
    [JsonPropertyName("title")]
    public string Titulo { get; set; }
    [JsonPropertyName("year")]
    public string Ano { get; set; }
    [JsonPropertyName("crew")]
    public string Elenco { get; set; }

    public string FichaTecnica => $"Título: {Titulo}, Ano: {Ano}, Elenco: {Elenco}";

   
}
