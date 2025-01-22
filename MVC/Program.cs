using BLL.Services.Abstracts;
using BLL.Services.Concretes;
using DAL.Context;
using DAL.Repositories.Abstracts;
using DAL.Repositories.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MODEL.Entities;
using MODEL.Entities.UserEntities;
using BLL.Services.Abstracts.FakeData;
using BLL.Services.Concretes.FakeData;
using BLL.Services.Abstracts.UserAbstracts;
using BLL.Services.Concretes.UserConcretes;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DBContext 
builder.Services.AddDbContext<ProjectContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//AddIdentity
builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ProjectContext>();

//Service Injection
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped(typeof(IJoinRepository<,,>),typeof(JoinRepository<,,>));
builder.Services.AddScoped(typeof(IJoinService<,,>),typeof(JoinService<,,>));
builder.Services.AddScoped(typeof(IFakeDataService<>),typeof(FakeDataService<>));
builder.Services.AddScoped<IEncryptionService, IEncryptionService>();
builder.Services.AddScoped<IPasswordHasher<User>,PasswordHasher<User>>();
builder.Services.AddScoped<IUserService, UserService>();

//Custom Services
builder.Services.AddScoped<IFilmService,FilmService>();

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

//app.MapControllerRoute(
//    name: "data",
//    pattern: "data/{action}/{count?}",
//    defaults: new { controller = "Data" });
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}");

app.Run();
