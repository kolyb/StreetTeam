using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StreetTeam.DataAccess.Models;

namespace StreetTeam.DataAccess.EntityFrameworkCore
{
    public class StreetTeamContext : IdentityDbContext
    { 
        public StreetTeamContext() { }

        public StreetTeamContext(DbContextOptions<StreetTeamContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }

        public DbSet<PlaceGame> PlaceGames { get; set; }

        public DbSet<StreetPlayer> StreetPlayers { get; set; }
    }
}
