using Microsoft.EntityFrameworkCore;
using tranhoangkhai_project1.Components;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<iDonViTinhService, DonViTinhService>();
builder.Services.AddScoped<iLoaiSanPhamService, LoaiSanPhamService>();
builder.Services.AddScoped<iSanPhamService, SanPhamService>();
builder.Services.AddScoped<iNhaCungCapService, NhaCungCapService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
