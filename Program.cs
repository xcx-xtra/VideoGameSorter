namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Halo", Genre = "Shooter", Rating = "3.5" });
            games.Add(new VideoGame { Name = "Super Mario", Genre = "Platformer", Rating = "4" });
            games.Add(new VideoGame { Name = "Call of Duty", Genre = "Shooter", Rating = "3" });
            games.Add(new VideoGame { Name = "Zelda", Genre = "Adventure", Rating = "5" });
            games.Add(new VideoGame { Name = "Minecraft", Genre = "Sandbox", Rating = "2.5" });

            // Query to get all games with a rating of 4 or higher 
            var topRatedGames = (from game in games 
                                where double.Parse(game.Rating) >= 3.5
                                select game).ToList(); 

            // Sort the games by Top Rated Games
            var sortedGames = (from game in topRatedGames
                                orderby game.Name
                                select game).ToList();

            // Print out the sorted games
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);}                    

    }//end Main
}}//end Program