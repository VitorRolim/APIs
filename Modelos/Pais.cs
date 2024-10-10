using System.Text.Json.Serialization;

namespace ClassesAPIs.Modelos;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string NomePais { get; set; }
    [JsonPropertyName("capital")]
    public string Capital { get; set; }
    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }
    [JsonPropertyName("continente")]
    public string Continente { get; set; }
    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

    public string DescricaoPais => $"País:{NomePais}, Capital: {Capital}, População: {Populacao}, Continente: {Continente}, Idioma: {Idioma}";
}
