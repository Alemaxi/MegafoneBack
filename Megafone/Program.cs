using Megafone.DI;
using Microsoft.EntityFrameworkCore;
using MySqlRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MysqlContext>(opt =>
{
    opt.UseInMemoryDatabase("MegafoneTest");
});

new CoreDI(builder.Services);
new UsuarioDI(builder.Services);
new MegafoneDI(builder.Services);
new MensagemDI(builder.Services);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var corsName = "allowAll";
builder.Services.AddCors(cors => cors.AddPolicy(corsName, builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(corsName);

app.UseAuthorization();

app.MapControllers();

app.Run();
