using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorAPI.ApiRequest;
using BlazorAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options =>
    {
        options.DetailedErrors = true;
    });

builder.Services.AddSignalR(options =>
{
    options.EnableDetailedErrors = true;
});

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<MovieService>();

builder.Services.AddHttpClient("UnauthorizedClient", client =>
{
    client.BaseAddress = new Uri("http://localhost:5256");
});

builder.Services.AddHttpClient("AuthorizedClient", client =>
{
    client.BaseAddress = new Uri("http://localhost:5256");
})
.AddHttpMessageHandler<AuthorizationMessageHandler>();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5256")
});

builder.Services.AddTransient<AuthorizationMessageHandler>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.SetIsOriginAllowed(_ => true)
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.UseCors("AllowAll");

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapBlazorHub();
    endpoints.MapHub<ChatHub>("/chatHub");
    endpoints.MapFallbackToPage("/_Host");
});

app.Run();
