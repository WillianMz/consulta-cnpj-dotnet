using ConsultaCnpjAPI.Models;
using ConsultaCnpjAPI.Util;
using System.Text.Json;

namespace ConsultaCnpjAPI.Services
{
    public class CnpjService : ICnpjService
    {
        public async Task<CnpjModel> ConsultarCPNJAsync(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj) || !Validacao.ValidaCNPJ(cnpj))
                throw new ArgumentException("CNPJ Invalido.");

            try
            {
                //using HttpResponseMessage response = await _httpClient.GetAsync(string.Format(Constantes.CNPJAPI, cnpj)).ConfigureAwait(false);

                HttpClient httpClient = new()
                {
                    BaseAddress = new Uri($"{Constantes.CNPJAPI}")
                };

                using HttpResponseMessage response = await httpClient.GetAsync($"{cnpj}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<CnpjModel>(result);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
