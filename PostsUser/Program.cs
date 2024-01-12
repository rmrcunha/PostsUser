using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using PostsUser.Context;
using PostsUser.Mappings;
using PostsUser.Repositories;
using PostsUser.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.
builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connection,
        b =>b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

builder.Services.AddScoped<IPostRepository, PostRepository>();

builder.Services.AddAutoMapper(typeof(DomainToDTOProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.Run();