using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = new()
{
    new GameDto(1, "Super Mario Bros", "Platform", 59.99m, new DateOnly(1985, 9, 13)),
    new GameDto(2, "The Legend of Zelda", "Action-adventure", 59.99m, new DateOnly(1986, 2, 21)),
    new GameDto(3, "Minecraft", "Sandbox", 26.95m, new DateOnly(2011, 11, 18))
};

app.MapGet("/games", () => games);

app.MapGet("/games/{id}", (int id) => games.Find(game => game.Id == id));

app.Run();
