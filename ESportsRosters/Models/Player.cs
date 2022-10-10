namespace ESportsRosters.Models
{
    public class Player
    {
        public int PlayerId { get; set; } //Player Id
        public string Name { get; set; } //Name of Each Player
        public string Role { get; set; } //Role of each player dependent on game (ex. Entry Frag, Jungler, etc.)
    }
}
