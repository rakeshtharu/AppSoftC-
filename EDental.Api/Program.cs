using EDental.Data;
using EDental.Infrastructure.Repositories.Implementations;
using EDental.Infrastructure.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//DEPENDANCY INJECTION KO LAGI Registration
builder.Services.AddDbContext<EDentalDbContext>();
builder.Services.AddScoped<IDoctorsRepository, DoctorsRepository>();
builder.Services.AddScoped<IDiagnosesRepository,DiagnosesRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
