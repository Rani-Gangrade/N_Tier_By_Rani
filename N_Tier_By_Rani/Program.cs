using BLL;
using DAL;
using DAL_Data_Access_Layer_.DbContextClasses;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<VotingDBContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddScoped<IVotingDAL, VotingDAL>();
builder.Services.AddScoped<IVotingBLL, VotingBLL>();



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
    pattern: "{controller=Voting}/{action=Index}/{id?}");

app.Run();
