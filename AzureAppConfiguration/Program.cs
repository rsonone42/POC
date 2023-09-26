using Azure.Identity;
using AzureAppConfiguration;

var builder = WebApplication.CreateBuilder(args);

string? connectionStringURI = builder.Configuration.GetConnectionString("AzureAppConfiguration_CS");
// Add services to the container.
builder.Configuration.AddAzureAppConfiguration(options =>
{
    var credential = new DefaultAzureCredential();
    options.Connect(new Uri(connectionStringURI), credential);
    options.ConfigureRefresh(refresh =>
    {
        refresh.Register("weather:Count").SetCacheExpiration(TimeSpan.FromSeconds(5));
    });
});

builder.Services.AddAzureAppConfiguration();
builder.Services.Configure<WeatherConfiguration>(builder.Configuration.GetSection("weather"));
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

app.UseAzureAppConfiguration();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
