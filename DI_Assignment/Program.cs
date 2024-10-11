using ServiceContract;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IWeatherService , WeatherService>();
var app = builder.Build();
app.UseRouting();
app.MapControllers();
app.UseStaticFiles();


app.Run();
