//Brandon Le
//10-27-22
//Mini Challenge 9 - Restaurant Picker
//Web API project that will give the user 3 options to choose from.In my case I chose asian food, fast food, and beverages as my 3 options. There is an instructions page at /minich9/ But by entering ASIAN, FAST, or DRINKS the user will get a randomized restaurant/business sent back to them. I also included error messages for when anything else is entered it will prompt them to enter it in correctly and I also provided links that they can click as well.
//Peer Review: Elizar Garcia - Outstanding job! By far one of the best projects I have come by so far. The coding is beautiful. Adding links to take you to the next page was impressive it also generated the randome food. Mind blowing and outstanding work! great job!!!!

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
