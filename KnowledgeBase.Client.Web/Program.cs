using KnowledgeBase.Client.Web.Utility;
using KnowledgeBase.Client.Web.Services;
using KnowledgeBase.Client.Web.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

#region Configure Static Details
StaticDetails.LanguagesAPIBase = builder.Configuration["ServiceUrls:LanguageAPI"];
#endregion

builder.Services.AddHttpClient();
builder.Services.AddHttpClient<ILanguageService, LanguageService>();

#region Register Services
builder.Services.AddScoped<IBaseService, BaseService>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
