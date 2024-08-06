using Microsoft.EntityFrameworkCore;
using StreetTeam.DataAccess.EntityFrameworkCore;
using StreetTeam.DataAccess.Interfaces;
using StreetTeam.DataAccess.Models;

namespace StreetTeam.DataAccess.Repositories
{
    public class StreetPlayerRepository : IRepository<StreetPlayer>
    {
        private readonly StreetTeamContext _db;

        public StreetPlayerRepository(StreetTeamContext db)
        {
            _db = db;
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task CreateAsync(StreetPlayer item)
        {
            _db.StreetPlayers.Add(item);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(StreetPlayer item)
        {
            _db.StreetPlayers.Remove(item);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<StreetPlayer> GetAll()
        {
            return _db.StreetPlayers.AsQueryable();
        }

        public async Task<StreetPlayer> GetByIdAsync(int? id)
        {
            var result = await _db.StreetPlayers.FindAsync(id);
            if (result == null)
            {
                throw new Exception();
            }
            return result;
        }

        public async Task UpdateAsync(StreetPlayer item)
        {
            _db.Entry(item).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
    }
}
