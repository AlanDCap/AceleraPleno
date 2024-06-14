using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProjetoAPI.Repository;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataBaseContext>(opt => opt.UseInMemoryDatabase("ListaDeClientes"));
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

var key = Encoding.ASCII.GetBytes("bLyXE8Dzlf0Nif+04z1D58LzV3A5VB0Ph+CAaMS5snV8YFJ4e21BQYcYs4fTnjmWKFdUwZM3ByM+Mc9H9agENA==");

builder.Services.AddAuthentication(auth =>
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

})
    .AddJwtBearer(auth =>
    {
        auth.RequireHttpsMetadata = false; //Não precisa do https por ser apenas teste
        auth.SaveToken = false;
        auth.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true, //config se valida com a chave de criptografia
            IssuerSigningKey = new SymmetricSecurityKey(key), //validação com base na chave de criptografia
            ValidateIssuer = false, //caminho - domínio
            ValidateAudience = false,
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
