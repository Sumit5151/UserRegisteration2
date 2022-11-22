using Microsoft.EntityFrameworkCore;
using UserRegisteration2.BAL.Respository;
using UserRegisteration2.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BrightDb2Context>(options => options.UseSqlServer(


    builder.Configuration.GetConnectionString("DefaultConnectionString")
    //"server=SUMIT; Database=BrightDB2; trusted_connection=true; trustServerCertificate=true"

    ));


builder.Services.AddScoped<IUserRepository, UserRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Registeration}/{id?}");

app.Run();
