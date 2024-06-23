using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Epic2_Task2
{
    public class Service
    {
        public static List<Game> Games = new List<Game>();

        static Service()
        {
            Games.Add(new Game
            {
                Id = 1,
                Name = "Doom eternal",
                Price = 1400,
                Category = "Slasher",
                Genres = new List<Genre>() { new Genre { Name = "Shooter", Description = "You are marine who must to kill deamons on the Mars" } }
            });

            Games.Add(new Game
            {
                Id = 2,
                Name = "Call of Duty",
                Price = 1800,
                Category = "Tactical",
                Genres = new List<Genre>() { new Genre { Name = "Shooter", Description = "Tactical shooter about WW3" } }
            });

            Games.Add(new Game
            {
                Id = 3,
                Name = "Stalker 2",
                Price = 900,
                Category = "RPG",
                Genres = new List<Genre>() { new Genre { Name = "Shooter", Description = "Explore the Exclusion Zone" } }
            });

            Games.Add(new Game
            {
                Id = 4,
                Name = "Hearts of iron 4",
                Price = 1200,
                Category = "Simulator",
                Genres = new List<Genre>() { new Genre { Name = "Strategy", Description = "Rule contry duryng WW3" } }
            });

            Games.Add(new Game
            {
                Id = 5,
                Name = "Company of heroes 2",
                Price = 450,
                Category = "Tactical",
                Genres = new List<Genre>() { new Genre { Name = "Strategy", Description = "Get the role of historycal comander" } }
            });

            Games.Add(new Game
            {
                Id = 6,
                Name = "Farming simulator",
                Price = 450,
                Category = "Simulator",
                Genres = new List<Genre>() { new Genre { Name = "Framing", Description = "Build your own farm" } }
            });

            Games.Add(new Game
            {
                Id = 7,
                Name = "Dota 2",
                Price = 0,
                Category = "Moba",
                Genres = new List<Genre>() { new Genre { Name = "Strategy", Description = "Moba game" } }
            });

            Games.Add(new Game
            {
                Id = 7,
                Name = "Legue of legends",
                Price = 0,
                Category = "Moba",
                Genres = new List<Genre>() { new Genre { Name = "Strategy", Description = "Another one moba game" } }
            });
        }

        public void GameByID(int id)
        {
            var game = Games.FirstOrDefault(x => x.Id == id);
            Console.WriteLine(game.Name);
        }

        public List<Game> PriceRange(int min, int max)
        {
            var inRange = Games.Where(g => g.Price >= min && g.Price <= max).ToList();
            
            foreach (var game in inRange)
            {
                Console.WriteLine(game.Name); 
            }

            return inRange;
        }

        public void GetByGenre(int id)
        {
            var selected = Games.FirstOrDefault(x => x.Id == id);

            var samegenre = Games.Where(game => game.Genres.Any(genre => genre.Name == selected.Genres[0].Name));

            foreach (var game in samegenre)
            {
                Console.WriteLine(game.Name);
            }
        }

        public List<Game> GenreFilter(List<string> genres)
        {
            var filtered = Games.Where(g => g.Genres.Any(genre => genres.Contains(genre.Name)));
            return filtered.ToList();
        }

        public List<Game> GetFirstFive(bool allGames = false)
        {
            if (!allGames)
            {
                return Games.Take(5).ToList(); 
            }
            else
            {
                return Games.ToList(); 
            }
        }
    }
}
