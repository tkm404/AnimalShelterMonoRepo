using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AnimalShelterApiContext>(
                dbContextOptions => dbContextOptions
                .UseMySql(
                    builder.Configuration["ConnectionStrings:DefaultConnection"],
                    ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
                )
);

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
}
);
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options => 
options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore)
.AddNewtonsoftJson(options=>options.SerializerSettings.ContractResolver = new DefaultContractResolver());

builder.Services.AddControllers();
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
else
{
    app.UseHttpsRedirection();
}

app.UseCors(options=>options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();
