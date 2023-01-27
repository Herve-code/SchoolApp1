using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SchoolApp.Models;

var builder = WebApplication.CreateBuilder(args);

//add the services to container

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//Register services here add by me

builder.Services.AddDbContext<ApplDbContext>(options=>options.UseSqlServer(
builder.Configuration.GetConnectionString("ApplDbConnection")));

var app = builder.Build();



    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Courses}/{action=Index}/{id?}");

    app.Run(); 


