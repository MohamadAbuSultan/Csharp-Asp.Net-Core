namespace GameStore.Api;

public record class CreateGameDtoint(
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate);