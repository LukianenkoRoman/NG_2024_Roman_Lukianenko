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
                    service.GameByID(id);
                    return;
                case 2:
                    service.PriceRange(500, 1500);
                    return;
                case 3:
                    service.GetByGenre(4); 
                    return;
                case 4:
                    var filtered = service.GenreFilter(new List<string>() { "Shooter", "Strategy" });

                    foreach (var game in filtered)
                    {
                        foreach (var genre in game.Genres)
                        {
                            Console.WriteLine(game.Name);
                            Console.WriteLine(genre.Name);
                        }
                    }
                    return;
                case 5:
                    List<Game> showGamens = service.GetFirstFive();
                    foreach (Game game in showGamens) 
                    {
                        Console.WriteLine($"Name: {game.Name}"); 
                        
                    }
                    Console.WriteLine("Show more? y or n");
                    string chos = Console.ReadLine();
                    if ( chos == "y")
                    {
                        List<Game> allGames = service.GetFirstFive(true);
                        foreach (Game game in allGames)
                        {
                            Console.WriteLine($"Name: {game.Name}");

                        }
                    }
                    return;
                default:
                    Console.WriteLine("Error.");
                    return;
            }
        }


        


        
    }
}