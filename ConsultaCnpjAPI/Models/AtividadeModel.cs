using System.Text.Json.Serialization;

namespace ConsultaCnpjAPI.Models
{
    public class AtividadeModel
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
