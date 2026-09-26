using RegretBook.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Repositories Registration

builder.Services.AddSingleton<UserRepository>();
// this says that instead of creating a new instance of UserRepository every time it's needed,let the builder provide the same instance of UserRepository whenever it's requested.
// this means that the same instance of UserRepository will be used throughout the application lifetime. This is useful for in-memory data storage, as it allows you to maintain a consistent state across different requests and controllers.



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();