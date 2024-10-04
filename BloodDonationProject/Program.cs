using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BloodDonationProject.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BloodDonationProjectContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("BloodDonationProjectContext") ?? throw new InvalidOperationException("Connection string 'BloodDonationProjectContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(builder =>
{
    builder
        .WithOrigins("http://localhost:4200") // Add your Angular app's domain here
        .AllowAnyHeader()
        .AllowAnyMethod();
});

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
