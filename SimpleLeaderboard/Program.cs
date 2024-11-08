using SimpleLeaderboard.Highscores;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.UseHttpsRedirection();

app.MapGet("/highscores", () =>
{
    var scores =  Enumerable.Range(1, 5).Select(index =>
        new HighScore()
        {
            PlayerName = "",
            PlayerId = 0,
            GameId = 0,
            Score = index,
        })
        .ToArray();
    return scores;
})
.WithName("GetHighScores")
.WithOpenApi();

app.Run();