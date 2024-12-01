using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using FoodRegistryApp1.Models;

var builder = WebApplication.CreateBuilder(args);

// Legg til nødvendige tjenester til containeren.
builder.Services.AddRazorPages();

// Legg til DbContext for tilkobling til SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodRegistryConnection"))
);

// Legg til autentisering (hvis du bruker det)
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";  // Angi login path
    });

// Legg til autorisasjonstjenester
builder.Services.AddAuthorization(options =>
{
    // Eksempel på å legge til en policy for autorisasjon
    // options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
});

var app = builder.Build();

// Konfigurer HTTP request-pipelinen.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Bruk autentisering og autorisasjon
app.UseAuthentication();  // Bruk autentiseringstjenesten


app.MapRazorPages();

app.Run();
