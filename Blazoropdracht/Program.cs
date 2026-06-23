using Blazoropdracht.Components;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=clients.db"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();
app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureDeleted();

    var sqlPath = Path.Combine(app.Environment.ContentRootPath, "Data", "init.sql");
    var sql = File.ReadAllText(sqlPath);
    db.Database.OpenConnection();
    using var command = db.Database.GetDbConnection().CreateCommand();
    command.CommandText = sql;
    command.ExecuteNonQuery();
    db.Database.CloseConnection();
}

app.Run();