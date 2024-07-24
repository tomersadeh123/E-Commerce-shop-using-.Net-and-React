using API.Data;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// adding api controller when we add new services it doenst matter their order. 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// adding the dbcontext service to talk with the db. using Lamda expression in order to use the sqlite.
builder.Services.AddDbContext<StoreContext>(opt => 
{
    // inside the sqllite () we need to send the configuration for the db.
    // we will use the builder => configuration > get connectiontostring inside the (DefaultConnection)
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//checking if we are running on dev mode, and if we are it will make avialbe the swagger.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// in this part of the code it is important the oder that we are insreting

app.UseAuthorization();

app.MapControllers();

var scope = app.Services.CreateScope();
//creating scopre for the db context.
var context = scope.ServiceProvider.GetRequiredService<StoreContext>();
//creating logs for the program.
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

try
{
    // checking if there is an db that running if not it will creat a new one 
    context.Database.Migrate();
    // creating the new db with the context that was created
    Intial.Intialize(context);

}
catch(Exception ex){
    logger.LogError(ex, "an error has occured during the migration!");
}

app.Run();

