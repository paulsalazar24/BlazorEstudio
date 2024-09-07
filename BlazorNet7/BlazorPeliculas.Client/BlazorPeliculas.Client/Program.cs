using BlazorPeliculas.Client;
using BlazorPeliculas.Client.Repositorios;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//y de esta maera llamas a la coleccion de servicios que forme
ConfigureServices(builder.Services);

await builder.Build().RunAsync();

///creamos una soleccion de los servicios para tenerlo ordenados 
void ConfigureServices(IServiceCollection services)
{
	services.AddSingleton<ServiciosSingleton>();
	services.AddTransient<ServiciosTransient>();
	services.AddSingleton<IRepositorio, Repositorio>();
}