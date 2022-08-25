using backend333;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var accountEndpoint = builder.Configuration.GetValue<string>("db:accountEndpoint");
var accountKey = builder.Configuration.GetValue<string>("db:key");
var name = builder.Configuration.GetValue<string>("db:name");
builder.Services.AddDbContext<DbContext333>(
    optionsAction: options => options.UseCosmos(
        accountEndpoint,
        accountKey,
        databaseName:name));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("corsapp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();