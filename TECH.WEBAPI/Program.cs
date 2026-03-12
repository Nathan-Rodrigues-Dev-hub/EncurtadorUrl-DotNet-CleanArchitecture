using MediatR;

var builder = WebApplication.CreateBuilder(args);

// 1. Registra os Controllers no container de DI
builder.Services.AddControllers();

// 2. Adiciona o MediaR (aponta para o seu projeto Application)
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(TECH.APPLICATION.Commands.CreateUrlCommand).Assembly));

// 3. Adiciona suporte ao Swagger (para testar fácil no navegador)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura o middleware do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers(); // Importante: Mapeia as rotas dos seus controllers

app.Run();