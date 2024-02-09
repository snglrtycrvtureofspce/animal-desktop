using System.Reflection;
using Asp.Versioning;
using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Service.Animals.Web.Data;
using snglrtycrvtureofspce.Core.Filters;
using SwaggerDefaultValues = Service.Animals.Web.Filters.SwaggerDefaultValues;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DeployConnection");
builder.Services.AddDbContext<AnimalsDbContext>(options =>
{
    if (connectionString != null) options.UseNpgsql(connectionString);
});

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .CreateLogger();

builder.Logging.ClearProviders().AddSerilog();
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var conf = new MapperConfiguration(p =>
{
    p.AddMaps(Assembly.GetExecutingAssembly());
});
var mapper = conf.CreateMapper();
builder.Services.AddScoped<IMapperBase>(_ => mapper);
builder.Services.AddSingleton(mapper);
builder.Services.AddHttpContextAccessor();

builder.Services.AddApiVersioning(
        options =>
        {
            // reporting api versions will return the headers
            // "api-supported-versions" and "api-deprecated-versions"
            options.ReportApiVersions = true;

            options.DefaultApiVersion = new ApiVersion(1.0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ReportApiVersions = true;

            options.ApiVersionReader = ApiVersionReader.Combine(
                new HeaderApiVersionReader("apiVersion")
            );

            options.Policies.Sunset(0.9)
                .Effective(DateTimeOffset.Now.AddDays(60))
                .Link("policy.html")
                .Title("Versioning Policy")
                .Type("text/html");
        })
    .AddMvc()
    .AddApiExplorer(
        options =>
        {
            // add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
            // note: the specified format code will format the version as "'v'major[.minor][-status]"
            options.GroupNameFormat = "'v'VVV";

            // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
            // can also be used to control the format of the API version in route templates
            options.SubstituteApiVersionInUrl = true;
        });

builder.Services.AddSwaggerGen(
    options =>
    {
        options.OperationFilter<SwaggerDefaultValues>();
        options.DocumentFilter<PathPrefixInsertDocumentFilter>(builder.Configuration.GetSection("Swagger")["Path"]);

        var fileName = typeof(SwaggerDefaultValues).Assembly.GetName().Name + ".xml";
        var filePath = Path.Combine(AppContext.BaseDirectory, fileName);

        options.IncludeXmlComments(filePath);

        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer"
        });

        options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });
    });

var app = builder.Build();

app.UseRouting();

app.UseSwagger();
app.UseSwaggerUI(
    options =>
    {
        var descriptions = app.DescribeApiVersions();
        
        foreach (var description in descriptions)
        {
            var url = $"{description.GroupName}/swagger.json";
            var name = description.GroupName.ToUpperInvariant();
            options.SwaggerEndpoint(url, name);
        }
    });

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();