using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using JeanLuis_AP1_P2.Data;
using JeanLuis_AP1_P2.DAL;
using JeanLuis_AP1_P2.BLL;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();

builder.Services.AddDbContext<Contexto>(options =>

                options.UseSqlite(builder.Configuration.GetConnectionString("ConStr"))

                );
builder.Services.AddTransient<CostoBLL>();
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

app.Run();
