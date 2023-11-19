using Microsoft.EntityFrameworkCore;
using WebAppLearnNet5.Middlewares;
using HM32_ASP.net_practice.DB;
using HM32_ASP.net_practice.DB.LoggingRepository;
using HM32_ASP.net_practice.DB.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped <IBlogRepository, BlogRepository>();
builder.Services.AddDbContext<BlogContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<ILoggingRepository, LoggingRepository>();
builder.Services.AddDbContext<LoggingContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LoggingConnectionString")), ServiceLifetime.Singleton);
builder.Services.AddControllersWithViews();
var app = builder.Build();


    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    else
    {
        app.UseExceptionHandler("/Home/Error");

        app.UseHsts();
    }

    app.UseMiddleware<LoggingMiddlewares>();

    app.UseHttpsRedirection();

    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    });
     app.Run();
    


