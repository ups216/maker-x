using MatchMaker.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMatchService, MatchService>();

var app = builder.Build();

app.MapGet("/match/{player}", async (string player, IMatchService matchService) =>
{
    return await matchService.FindMatchAsync(player);
})
.WithName("Match");

app.Run();
