using TomorowMind.Genesis.Web.Components;

var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

#endregion

var app = builder.Build();

#region Middleware

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

#endregion

#region Endpoints

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

#endregion

app.Run();