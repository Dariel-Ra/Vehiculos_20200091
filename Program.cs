using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Vehiculos_20200091.Data;
using Vehiculos_20200091.Data.Context;
using Vehiculos_20200091.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSqlite<Vehiculos_20200091DbContext>("Data Source=.//Data//Context//MyDb.sqlite");
builder.Services.AddScoped<IVehiculos_20200091DbContext,Vehiculos_20200091DbContext>();
builder.Services.AddScoped<IVehiculos_20200091Service,Vehiculos_20200091Service>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<Vehiculos_20200091DbContext>();
    if (db.Database.EnsureCreated())
    {
       
    }
    Vehiculos_20200091Seeder.Inicializar(db);
}

app.Run();
