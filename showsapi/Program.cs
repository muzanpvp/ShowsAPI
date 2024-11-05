using Microsoft.EntityFrameworkCore;
using showsapi.Context;
using showsapi.Interfaces;
using showsapi.Models;
using showsapi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IInscricaoInterface, InscricaoService>();
builder.Services.AddTransient<IShowsInterface, ShowsService>();
builder.Services.AddTransient<INotaFiscalInterface, NotaFiscalService>();
builder.Services.AddTransient<IUsuarioInterface, UsuarioService>();

   builder.Services.AddDbContext<ShowAPIContext>(
                options => options.UseMySQL(builder.Configuration.GetConnectionString("ShowAPI")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

app.Run();