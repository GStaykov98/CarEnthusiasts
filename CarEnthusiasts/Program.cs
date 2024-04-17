using CarEnthusiasts.Data;
using CarEnthusiasts.Data.Contracts.CarInformation;
using CarEnthusiasts.Data.Contracts.Comments;
using CarEnthusiasts.Data.Contracts.Compare;
using CarEnthusiasts.Data.Contracts.Forum;
using CarEnthusiasts.Data.Contracts.News;
using CarEnthusiasts.Data.Contracts.TuningParts;
using CarEnthusiasts.Data.Services.CarInformation;
using CarEnthusiasts.Data.Services.Comments;
using CarEnthusiasts.Data.Services.Compare;
using CarEnthusiasts.Data.Services.Forum;
using CarEnthusiasts.Data.Services.News;
using CarEnthusiasts.Data.Services.TuningParts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => 
{
    options.SignIn.RequireConfirmedEmail = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
})
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<INewsService, NewsService>();
builder.Services.AddScoped<ICarInformationService, CarInformationService>();
builder.Services.AddScoped<ICompareService, CompareService>();
builder.Services.AddScoped<IForumService, ForumService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ITuningPartsService, TuningPartsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
	app.UseStatusCodePagesWithRedirects("/Error/Error?statusCode={0}");
}
else
{
    app.UseExceptionHandler("/Error/Error/500");
    app.UseStatusCodePagesWithRedirects("/Error/Error?statusCode={0}");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=News}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
