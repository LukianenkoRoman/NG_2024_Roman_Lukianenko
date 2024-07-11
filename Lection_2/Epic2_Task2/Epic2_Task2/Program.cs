using Epic2_Task2;
using System;

class Program
{

    static void Main(string[] args)
    {
        Service service = new Service();

        Console.WriteLine("1-Exit");
        Console.WriteLine("2-Add person");
        Console.WriteLine("3-Get by name");
        Console.WriteLine("4-Get by phpne");
        Console.WriteLine("5-Display all");


        int choice = int.Parse(Console.ReadLine());

        while (true)
        {
            switch (choice)
            {
                case 1:
                    int id = 3;
                    service.GetGameByID(id);
                    return;
                case 2:
                    service.GetGaneByPriceRange(500, 1500);
                    return;
                case 3:
                    int gameId = 3;
                    string resault = service.GetGenresByGameId(gameId);
                    Console.WriteLine(resault);
                    return;
                case 4:
                    List<string> genre = new List<string>() { "Strategy" };
                    List<string> category = new List<string>() { "Moba" };

                    List<Game> filteredGames = service.GetFilteredByGenre(genre, category);

                    foreach (var game in filteredGames)
                    {
                        Console.WriteLine(game.Name);
                    }
                    return;
                case 5:
                    int pageNumber = 0;
                    int pageSize = 5;

                    List<Game> paginatedGames = service.GetGamesByPagination(pageNumber, pageSize);
                    
                    foreach (Game game in paginatedGames)
                    {
                        Console.WriteLine(game.Name);
                    }
                    return;
                case 6:
                    List<string> uniqueCategories = service.GetUniqueCategories();

                    foreach (string uniqueCategory in uniqueCategories)
                    {
                        Console.WriteLine(uniqueCategory);
                    }
                    return;
                default:
                    Console.WriteLine("Error.");
                    return;
            }
        }


        


        
    }
}