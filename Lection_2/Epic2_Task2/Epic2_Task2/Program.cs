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
                    var games = service.GetGameByGenre(5); 
                    foreach (var game in games)
                    {
                        Console.WriteLine(game.Name);
                    }
                    return;
                case 4:
                    var filteredGames = service.GetFilteredByGenre(new List<string>() { "Shooter", "Strategy" });

                    foreach (var game in filteredGames)
                    {
                        foreach (var genre in game.Genres)
                        {
                            Console.WriteLine(game.Name);
                            Console.WriteLine(genre.Name);
                        }
                    }
                    return;
                case 5:
                    var firstPage = service.GetGamesByPagination(new PaginationModel { PageNumber = 1, PageSize = 5 });

                    var secondPage = service.GetGamesByPagination(new PaginationModel { PageNumber = 2, PageSize = 5 });

                    Console.WriteLine("Page 1:");
                    foreach (var game in firstPage)
                    {
                        Console.WriteLine(game.Name);
                    }
                    Console.WriteLine("Page 2:");
                    foreach(var game in secondPage)
                    {
                        Console.WriteLine(game.Name);
                    }
                    return;
                default:
                    Console.WriteLine("Error.");
                    return;
            }
        }


        


        
    }
}