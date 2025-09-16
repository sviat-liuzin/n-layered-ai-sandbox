using RedPanda.NLayered.Application;
using RedPanda.NLayered.Data.Sql;
using ApplicationServiceCollectionExtensions = RedPanda.NLayered.Application.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddRedPandaNLayeredDataSql(connectionString);
builder.Services.AddRedPandaNLayeredApplication();

builder.Services.AddAutoMapper(cfg => {}, typeof(ApplicationServiceCollectionExtensions));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

app.UseHttpsRedirection();

app.Run();
