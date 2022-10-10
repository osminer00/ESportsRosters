namespace ESportsRosters.Models
{
    public class Game
    {
        public int GameId { get; set; } //Game Id
        public string Title { get; set; } //Name of current Game (ex. Counter Strike Global Offensive, League Of Legends, Rainbow Six Siege, etc.)
        public string Description { get; set; } //Short description for each game to be displayed on the page
        
    }
}
