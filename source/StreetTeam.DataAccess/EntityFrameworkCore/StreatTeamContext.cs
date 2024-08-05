using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StreetTeam.DataAccess.Models;

namespace StreetTeam.DataAccess.EntityFrameworkCore
{
    public class StreatTeamContext : IdentityDbContext
    { 
        public StreatTeamContext() { }

        public StreatTeamContext(DbContextOptions<StreatTeamContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }

        public DbSet<PlaceGame> PlaceGames { get; set; }

        public DbSet<StreetPlayer> StreetPlayers { get; set; }
    }
}
