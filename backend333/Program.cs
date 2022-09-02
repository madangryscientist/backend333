using System.Net.Http.Headers;
using backend333;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var DbPath = builder.Configuration.GetValue<string>("Db:Path");
builder.Services.AddDbContext<DbContext333>(
    optionsAction: options => options.UseSqlite(connectionString: $"Data Source={DbPath}"));
// Add services to the container.
builder.Services.AddHttpClient<SlackService>(i =>
{
    i.BaseAddress = new Uri("https://slack.com/api/");
    i.DefaultRequestHeaders.Authorization =
        new AuthenticationHeaderValue("Bearer", builder.Configuration.GetValue<string>("Slack:Token"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p =>
    p.AddPolicy("corsapp", builder => { builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader(); }));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();