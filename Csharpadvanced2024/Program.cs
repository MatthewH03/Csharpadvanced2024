//Matthew Hiraki S1169167

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Csharpadvanced2024.Data;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using Csharpadvanced2024;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Csharpadvanced2024.Services;
using Csharpadvanced2024.Repositories;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext") ?? throw new InvalidOperationException("Connection string 'AppDbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("1.0", new OpenApiInfo { Title = "Csharpadvanced 2024", Version = "1.0" });
    options.SwaggerDoc("2.0", new OpenApiInfo { Title = "Csharpadvanced 2024", Version = "2.0" });
    options.DocInclusionPredicate((docName, apiDesc) =>
    {
        if (!apiDesc.TryGetMethodInfo(out MethodInfo method))
            return false;

        var versions = method.DeclaringType
                        .GetCustomAttributes(true)
                        .OfType<ApiVersionAttribute>()
                        .SelectMany(attr => attr.Versions);

        return versions.Any(v => $"{v}" == docName);
    });

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    options.OperationFilter<AddApiVersionQueryParamOperationFilter>();
});

builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0); // Standaard naar versie 1.0
    options.ReportApiVersions = true;
    options.ApiVersionReader = new QueryStringApiVersionReader("api-version");
}).AddMvc();

builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("AllowWebApp", builder =>
    {
        builder.WithOrigins("https://cloudbnb-df3c1.web.app")
            .AllowAnyHeader()
           .AllowAnyMethod();
    });
});
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<ILocationRepo, LocationRepo>();
builder.Services.AddScoped<IReservationService, ReservationService>();
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(config =>
    {
        config.SwaggerEndpoint("/swagger/1.0/swagger.json", "Csharpadvanced 2024 API v1");
        config.SwaggerEndpoint("/swagger/2.0/swagger.json", "Csharpadvanced 2024 API v2");
    });
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowWebApp");

app.MapControllers();

app.Run();
