namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        var developedGames = Games
       .Where(game => game.DeveloperStudio == gameStudio.Id)
       .ToList();
        return developedGames;
    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        var games = from Game in Games
                    where Game.Players.Contains(player.Id)
                    select Game;
        return games.ToList();

    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        var games = from Game in Games
                    where playerEntry.GamesOwned.Contains(Game.Id)
                    select Game;
        return games.ToList();
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        var allGames = from game in Games
                       from gameStudio in GameStudios
                       where gameStudio.Id == game.DeveloperStudio

                       select new GameWithStudio
                       {
                           GameName = game.Name,
                           StudioName = gameStudio.Name,
                           NumberOfPlayers = game.Players.Count,
                       };

        return allGames.ToList();
    }

    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        var gameTypes = Games
       .Select(game => game.GameType)
       .Distinct()
       .ToList();

        return gameTypes;
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        var studiosWithGamesAndPlayers = GameStudios
       .Select(studio => new StudioGamesPlayers
       {
           GameStudioName = studio.Name,
           Games = Games
               .Where(game => game.DeveloperStudio == studio.Id)
               .Select(game => new GamePlayer
               {
                   GameName = game.Name,
                   Players = Players
                       .Where(player => game.Players.Contains(player.Id))
                       .ToList()
               })
               .ToList()
       })
       .ToList();

        return studiosWithGamesAndPlayers;
    }

}
