using StreetTeam.DataAccess.Interfaces;
using StreetTeam.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetTeam.DataAccess.Repositories
{
    public class StreetPlayerRepository : IRepository<StreetPlayer>
    {
        public Task CreateAsync(StreetPlayer item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(StreetPlayer item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StreetPlayer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StreetPlayer> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(StreetPlayer item)
        {
            throw new NotImplementedException();
        }
    }
}
