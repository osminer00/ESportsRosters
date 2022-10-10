namespace ESportsRosters.Models
{
    public class Team
    {
        public int TeamId { get; set; } //Team Id
        public string Name { get; set; } //Name of Team (ex. Team Liquid, Navi, Evil Genious, etc.)
        public string Region { get; set; } // Location Each Team is from (ex. NA, CIS, EU, etc.) *Add digit restriction of 5 and capitaliation

    }
}
