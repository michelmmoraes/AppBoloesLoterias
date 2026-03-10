using AppBoloesLoterias;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Supabase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// ==========================================
// CONFIGURAÇÃO DO SUPABASE
// ==========================================
var url = "https://zelqjvyesqjlmpevcaol.supabase.co";
var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InplbHFqdnllc3FqbG1wZXZjYW9sIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzI4OTUxMTYsImV4cCI6MjA4ODQ3MTExNn0.9aJQZUdO2KUZsR6-eJDm_EQ95iuMj7pjst_drBTOKd0";

var options = new SupabaseOptions
{
    AutoConnectRealtime = false
};

// 1. Criamos o cliente
var supabase = new Supabase.Client(url, key, options);

// 2. LIGAMOS O MOTOR (para ele reconhecer a chave)
await supabase.InitializeAsync();

// 3. Injetamos o banco de dados pronto e ligado no aplicativo
builder.Services.AddScoped<Supabase.Client>(_ => supabase);
// ==========================================

await builder.Build().RunAsync();