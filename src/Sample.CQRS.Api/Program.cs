using Sample.CQRS.Api.Domain.Handlers;
using Sample.CQRS.Api.Domain.Repositories;
using Sample.CQRS.Api.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<ICacheService, CacheService>();
builder.Services.AddTransient<ICreateProductHandler, CreateProductHandler>();
builder.Services.AddTransient<IFindProductByIdHandler, FindProductByIdHandler>();

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
