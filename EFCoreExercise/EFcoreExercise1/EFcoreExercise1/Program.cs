using EFcoreExercise1.Data;
using EFcoreExercise1.Models;

using Microsoft.EntityFrameworkCore;

namespace EFcoreExercise1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ×¢ƒÔ CompanyContext
            builder.Services.AddDbContext<CompanyContext>(opts =>
                opts.UseSqlite(builder.Configuration.GetConnectionString("SqliteDefaultConnection")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            #region Entity Framework Core Seed Data
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<CompanyContext>();
                context.Database.EnsureCreated();
                DbInitializer.Initialize(context);
            }
            #endregion

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
