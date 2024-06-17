namespace StreetTeam.DataAccess.Models
{
    public class Event
    {
        public int? IdEvent { get; set; }

        public string? NameEvent { get; set; }

        public DateTime? DateTimeEvent { get; set; }

        public int?  PlaceGameId { get; set; }

        public int?  StreetPlayerId { get; set; }
    }
}
