using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using tranhoangkhai_project1.Components;
using tranhoangkhai_project1.Data;
using tranhoangkhai_project1.Helper;
using tranhoangkhai_project1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")),
    ServiceLifetime.Transient);

builder.Services.AddScoped<iDonViTinhService, DonViTinhService>();
builder.Services.AddScoped<iLoaiSanPhamService, LoaiSanPhamService>();
builder.Services.AddScoped<iSanPhamService, SanPhamService>();
builder.Services.AddScoped<iNhaCungCapService, NhaCungCapService>();
builder.Services.AddScoped<iKhoService, KhoService>();
builder.Services.AddScoped<iKhoUserService, KhoUserService>();
builder.Services.AddScoped<iPhieuNhapKhoService, PhieuNhapKhoService>();
builder.Services.AddScoped<iChiTietPhieuNhapKhoService, ChiTietPhiNhapKhoService>();
builder.Services.AddScoped<iPhieuXuatKhoService, PhieuXuatKhoService>();
builder.Services.AddScoped<iChiTietPhieuXuatKhoService, ChiTietPhieuXuatService>();
builder.Services.AddScoped<ShowErrorMessage>();


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
