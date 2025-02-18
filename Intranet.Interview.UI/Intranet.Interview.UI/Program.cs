using Intranet.Interview.UI.Client.Pages;
using Intranet.Interview.UI.Client.Services.FormSrv;
using Intranet.Interview.UI.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Hosting;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();

builder.Services.AddScoped(sp =>
{
    NavigationManager navigation = sp.GetRequiredService<NavigationManager>();
    return new HttpClient { BaseAddress = new Uri(navigation.BaseUri) };
});
builder.Services.AddMudServices();
builder.Services.AddTransient<IFormService, FormService>();
builder.Services.AddSingleton<IFilePath>(_ => new FilePath(Path.Combine(builder.Environment.WebRootPath, "DynamicForm.json")));
var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.MapControllers();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Intranet.Interview.UI.Client._Imports).Assembly);

app.Run();
