using FullStackApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FullStackDbContext>(options => options.UseSqlServer
    (builder.Configuration.GetConnectionString("FullStackConnectionString1")));

builder.Services.AddDbContext<FullStackDbContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("EcommerceConnectionString")));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
{
    builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
}
    );
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

IApplicationBuilder applicationBuilder = app.UseCors();


app.UseAuthorization();

app.MapControllers();

app.Run();
