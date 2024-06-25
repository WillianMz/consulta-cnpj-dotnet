using System.Text.Json.Serialization;

namespace ConsultaCnpjAPI.Models
{
    public class CnpjModel
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("ultima_atualizacao")]
        public string UltimaAtualizacao { get; set; }
        [JsonPropertyName("cnpj")] 
        public string CNPJ { get; set; }
        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }
        [JsonPropertyName("porte")]
        public string Porte { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("fantasia")]
        public string Fantasia { get; set; }
        [JsonPropertyName("abertura")]
        public string DataAbertura { get; set; }

        [JsonPropertyName("natureza_juridica")]
        public string NaturezaJuridica { get; set; }
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }
        [JsonPropertyName("numero")]
        public string Numero { get; set; }
        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }
        [JsonPropertyName("cep")]
        public string CEP { get; set; }
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }
        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }
        [JsonPropertyName("uf")]
        public string UF { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("telefone")]
        public string Telefone { get; set; }
        [JsonPropertyName("efr")]
        public string EnteFederativoResponsavel { get; set; }
        [JsonPropertyName("situacao")]
        public string Situacao { get; set; }
        [JsonPropertyName("data_situacao")]
        public string DataSituacao { get; set; }
        [JsonPropertyName("motivo_situacao")]
        public string MotivoSituacao { get; set; }
        [JsonPropertyName("situacao_especial")]
        public string SituacaoEspecial { get; set; }
        [JsonPropertyName("data_situacao_especial")]
        public string DataSituacaoEspecial { get; set; }
        [JsonPropertyName("capital_social")]
        public string CapitalSocial { get; set; }

        [JsonPropertyName("atividade_principal")]
        public List<AtividadeModel> AtividadePrincipal { get; set; } = [];


        [JsonPropertyName("atividades_secundarias")]
        public List<AtividadeModel> AtividadesSecundarias { get; set; } = [];

        [JsonPropertyName("qsa")]
        public List<QsaModel> QuadroSocietario { get; set; } = [];
    }
}