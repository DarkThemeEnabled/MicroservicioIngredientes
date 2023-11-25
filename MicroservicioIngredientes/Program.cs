using Application.Interfaces;
using Application.UseCase;
using Infraestructure.Command;
using Infraestructure.Persistence;
using Infraestructure.Querys;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<IngredientesDBContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddScoped<IIngredienteCommand, IngredienteCommand>();
builder.Services.AddScoped<IIngredienteQuery, IngredienteQuery>();
builder.Services.AddScoped<IIngredienteService, IngredienteService>();

builder.Services.AddScoped<ITipoIngredienteCommand, TipoIngredienteCommand>();
builder.Services.AddScoped<ITipoIngredienteQuery, TipoIngredienteQuery>();
builder.Services.AddScoped<ITipoIngredienteService, TipoIngredienteService>();

builder.Services.AddScoped<ITipoMedidaCommand, TipoMedidaCommand>();
builder.Services.AddScoped<ITipoMedidaQuery, TipoMedidaQuery>();

// (DESCOMENTAR LUEGO) agregado servicio de token

//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, jwtBearerOptions =>
//{
//    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
//    {
//        IssuerSigningKey = new SymmetricSecurityKey(
//            Encoding.UTF8.GetBytes(builder.Configuration["AppSettings:Secret"])
//        ),
//        ValidIssuer = "localhost",
//        ValidAudience = "usuarios",
//        ValidateLifetime = true
//    };
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
