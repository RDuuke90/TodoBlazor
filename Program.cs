using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TodoApi;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com/") });

await builder.Build().RunAsync();
/**
    http://localhost:5745 -> https://jsonplaceholder.typicode.com/
    GET -> /todo -> Json
    GET -> /todo/1 -> Json

    1- Componente que embede directamente y carga todos los TODO
    2- Componente que le envio 1 parametro por la url y me carga el detalle del TODO.
**/