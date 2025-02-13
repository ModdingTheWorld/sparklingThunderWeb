using Domain.Interfaces;
using Domain.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entites;
using WebGUI.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<ItemContext>(
    options => options.UseMySql(
        builder.Configuration
            .GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 27))
    )
);
builder.Services.AddTransient<IRepository<Item>,ItemRepository>();
builder.Services.AddTransient<IRepository<Block>,BlockRepository>();
builder.Services.AddTransient<IRepository<Entity>,EntityRepository>();
builder.Services.AddTransient<IRepository<Structure>,StructureRepository>();
builder.Services.AddTransient<IRepository<Tool>,ToolRepository>();
builder.Services.AddTransient<IRepository<Weapon>,WeaponRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();