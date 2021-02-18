using TestApplication.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GamesController : ControllerBase
    {
        public static List<Games> GetGames()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games() { Id = 1, Name = "Game 1", price = 10 });
            games.Add(new Games() { Id = 2, Name = "Game 2", price = 15 });
            games.Add(new Games() { Id = 3, Name = "Game 3", price = 20 });
            games.Add(new Games() { Id = 4, Name = "Game 4", price = 25 });
            games.Add(new Games() { Id = 5, Name = "Game 5", price = 30 });
            return games;
        }
        [HttpGet]
        public IEnumerable<Games> GetGames_List()
        {
            return GetGames();
        }
        [HttpGet("{id}")]
        public ActionResult<Games> GetGames_ById(int id)
        {
            var games = GetGames().Find(x => x.Id == id);
            if(games != null)
            {
                return games;
            }
            else
            {
                return NotFound();           
            }
            
        }
    }

}