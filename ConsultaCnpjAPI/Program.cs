using ConsultaCnpjAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//base de dados mySQL/mariadb
string connectionString = $"Server=localhost;";
connectionString += $"Port=3306;";
connectionString += $"Database=dados_cnpj;";
connectionString += $"Uid=root;";
connectionString += $"Pwd=";

MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 2, 4));


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICnpjService, CnpjService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/consultar/{cnpj}", async (string cnpj) =>
{
    var service = new CnpjService();
    return await service.ConsultarCPNJAsync(cnpj);
}).WithName("Consultar CNPJ").WithOpenApi();

app.Run();
