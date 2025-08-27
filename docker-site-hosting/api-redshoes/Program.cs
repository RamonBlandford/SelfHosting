using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// --- Services ---
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// OPTIONAL CORS (usually not needed with Option B: same-origin /api)
// Enable by setting Cors:Enabled=true and list origins in config/env if you truly need it.
var enableCors = builder.Configuration.GetValue("Cors:Enabled", false);
if (enableCors)
{
    var allowed = builder.Configuration.GetSection("Cors:Origins").Get<string[]>()
                  ?? new[] { "https://selfcompassionclinic.com", "https://redshoestechnology.com" };
    builder.Services.AddCors(opts =>
        opts.AddPolicy("VueOnlyPolicy", p => p.WithOrigins(allowed)
                                              .AllowAnyHeader()
                                              .AllowAnyMethod()));
}

// HTTP binding: prefer ASPNETCORE_URLS; otherwise fall back to a config port.
// (Do NOT enable HTTPS here; Caddy terminates TLS.)
var urlsEnv = Environment.GetEnvironmentVariable("ASPNETCORE_URLS");
if (string.IsNullOrWhiteSpace(urlsEnv))
{
    var httpPort = builder.Configuration.GetValue("Kestrel:HttpPort", 5000);
    builder.WebHost.ConfigureKestrel(o => o.ListenAnyIP(httpPort));
}

var app = builder.Build();

// --- Middleware order ---
// Make sure forwarded headers are applied early (we're behind Caddy).
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

if (enableCors) app.UseCors("VueOnlyPolicy");

// Swagger (good for dev; gate with if (app.Environment.IsDevelopment()) if desired)
app.UseSwagger();
app.UseSwaggerUI();

// Map controllers under whatever routes you defined (e.g., /api/...)
app.MapControllers();

app.Run();