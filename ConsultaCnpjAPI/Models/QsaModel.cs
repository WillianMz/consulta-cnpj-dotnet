using System.Text.Json.Serialization;

namespace ConsultaCnpjAPI.Models
{
    public class QsaModel
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("qual")]
        public string Qual { get; set; }
        [JsonPropertyName("pais_origem")]
        public string PaisOrigem { get; set; }
        [JsonPropertyName("nome_rep_legal")]
        public string NomeRepresentanteLegal { get; set; }
        [JsonPropertyName("qual_reo_legal")]
        public string QualRepresentanteLegal { get; set; }
    }
}