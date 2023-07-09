// See https://aka.ms/new-console-template for more information
using Consulta.CNPJ.Models;
using Consulta.CNPJ.Services;

Console.WriteLine("WN Consulta CNPJ");
Console.WriteLine($"Digite o CNPJ, somente os números: ");

var cnpjConsulta = Console.ReadLine();

Console.WriteLine("Consultando CNPJ, aguarde....");

CNPJService service = new();
CNPJResult cnpj = service.ConsultarCPNJ(cnpjConsulta);

Console.WriteLine("*******************************************");
Console.WriteLine($"Razão Social: {cnpj.Nome}");
Console.WriteLine($"Nome Fantasia: {cnpj.Fantasia}");
Console.WriteLine($"CNPJ: {cnpj.Cnpj}");
Console.WriteLine($"Natureza Juridica: {cnpj.NaturezaJuridica}");
Console.WriteLine($"Data da Situação: {cnpj.DataSituacao}");
Console.WriteLine($"Data de abertura: {cnpj.Abertura}");
Console.WriteLine($"Capital Social: {cnpj.CapitalSocial}");
Console.WriteLine($"Telefone: {cnpj.Telefone}");
Console.WriteLine($"Email: {cnpj.Email}");
Console.WriteLine($"CEP: {cnpj.Cep}");
Console.WriteLine($"Logradouro: {cnpj.Logradouro}");
Console.WriteLine($"Número: {cnpj.Numero}");
Console.WriteLine($"Complemento: {cnpj.Complemento}");
Console.WriteLine($"Bairro: {cnpj.Bairro}");
Console.WriteLine($"Cidade: {cnpj.Municipio}");
Console.WriteLine($"UF: {cnpj.Uf}");
Console.WriteLine($"{cnpj.Efr}");
Console.WriteLine($"Situação: {cnpj.Situacao}");
Console.WriteLine($"Motivo Situação: {cnpj.MotivoSituacao}");
Console.WriteLine($"Situação Especial: {cnpj.SituacaoEspecial}");
Console.WriteLine($"Data da Situação Especial: {cnpj.DataSituacaoEspecial}");
Console.WriteLine($"Data da última atualização: {cnpj.UltimaAtualizacao}");
Console.WriteLine($"Status: {cnpj.Status}");
Console.WriteLine($"Tipo: {cnpj.Tipo}");

Console.WriteLine("Atividades principais *********************");
var contAtividadePrincipal = 1;
List<Atividade> atividadePrincipal = cnpj.AtividadePrincipal;
foreach (var item in atividadePrincipal)
{
    Console.WriteLine($"{contAtividadePrincipal}: {item.Code} - {item.Text}");
    contAtividadePrincipal++;
}

Console.WriteLine("Atividades secundárias ********************");
var contAtividadeSecondaria = 1;
List<Atividade> atividadesSecundarias = cnpj.AtividadesSecundarias;
foreach (var item in atividadesSecundarias)
{
    Console.WriteLine($"{contAtividadeSecondaria}: {item.Code} - {item.Text}");
    contAtividadeSecondaria++;
}

Console.WriteLine("Quadro societário **************************");
var contQSA = 1;
List<Qsa> qsa = cnpj.Qsa;
foreach (var item in qsa)
{
    Console.WriteLine($"Sócio: {contQSA}");
    Console.WriteLine($"{item.Qual}");
    Console.WriteLine($"{item.Nome}");
    Console.WriteLine($"{item.QualRepLegal}");
    Console.WriteLine($"{item.NomeRepLegal}");
    Console.WriteLine($"{item.PaisOrigem}");
    contQSA++;
}

Console.WriteLine("*******************************************");
Console.ReadLine();