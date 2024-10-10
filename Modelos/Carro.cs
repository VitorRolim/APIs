using System.Text.Json.Serialization;

namespace ClassesAPIs.Modelos;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }
    [JsonPropertyName("ano")]
    public int Ano { get; set; }
    public string DescricaoCarro => $"Marca do carro: {Marca}, modelo do carro: {Modelo}, Ano do carro: {Ano}";

}
