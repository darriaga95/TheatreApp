WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

WebApplication webApplication = builder.Build();
webApplication.UseHttpsRedirection();
webApplication.UseRouting();
webApplication.UseAuthentication();
webApplication.UseAuthorization();
webApplication.MapStaticAssets();
webApplication.MapControllers().WithStaticAssets();
webApplication.UseStaticFiles();
webApplication.Run();
