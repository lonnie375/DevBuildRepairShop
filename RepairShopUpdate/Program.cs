using MySql.Data.MySqlClient;
using RepairShopAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "LocalOriginsPolicy",
		builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
	);
}
);


var app = builder.Build();

app.UseCors("LocalOrginsPolicy");


//new code 
// global cors policy
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
                                        //.WithOrigins("https://localhost:44351")); // Allow only this origin can also have multiple origins separated with comma
    .AllowCredentials()); // allow credentials

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

string connstring = app.Configuration.GetConnectionString("db");
DAL.CS = connstring; 
//Get rid of this. This isn't needed;DAL.DB = new MySqlConnection(connstring); // Need the using statement above


app.Run();
