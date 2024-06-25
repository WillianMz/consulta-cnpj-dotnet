using ConsultaCnpjAPI.Models;

namespace ConsultaCnpjAPI.Services
{
    public interface ICnpjService
    {
        Task<CnpjModel> ConsultarCPNJAsync(string cnpj);
    }
}
