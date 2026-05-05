using Microsoft.AspNetCore.Mvc;
using Modul10_103022400131.Models;

namespace Modul10_103022400131.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameControllers : ControllerBase
    {
        private static List<Game> gameList = new List<Game>
        {
            new Game{nama = "Valorant", developer = "RiotGames", tahunRilis = 2020, genre = "FPS", rating = 8.5, platform = { "PC" }, mode = { "Multiplayer" }, isOnline = true, harga = 0 },
            new Game{nama = "GTA V", developer = "RockstarGames", tahunRilis = 2013, genre = "Open World", rating = 9.5, platform = { "PC", "PS4", "PS5", "XBOX" }, mode = { "SingleMultiplayer","Multiplayer" }, isOnline = true, harga = 300000 },
            new Game{nama = "The Witcher 3", developer = "RiotGames", tahunRilis = 2020, genre = "FPS", rating = 8.5, platform = { "PC" }, mode = { "Multiplayer" }, isOnline = true, harga = 0 },
            new Game{nama = "GTA V", developer = "CD Project Red", tahunRilis = 2015, genre = "RPG", rating = 9.7, platform = { "PC", "PS4", "PS5", "XBOX", "SWITCH" }, mode = { "SingleMultiplayer" }, isOnline = false, harga = 250000 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetAll()
        {
            return gameList;
        }
        [HttpGet("{index}")]
        public ActionResult<Game> GetByIndex(int index)
        {
            if (index < 0 || index >= gameList.Count)
                return NotFound("game tidak ditemukan");

            return gameList[index];
        }

        [HttpPost]
        public ActionResult Addgame([FromBody] Game game)
        {
            gameList.Add(game);
            return Ok("game berhasil ditambahkan");
        }

        [HttpDelete("{index}")]
        public ActionResult Deletegame(int index)
        {
            if (index < 0 || index >= gameList.Count)
                return NotFound("game tidak ditemukan");

            gameList.RemoveAt(index);
            return Ok("game berhasil dihapus");
        }
    }
}
