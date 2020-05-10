using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BackEnd.Data;
using ConferenceDTO;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Repository
{
    public class SpeakerRepository : Repository
    {
        private readonly ApplicationDbContext _dbContext;

        public SpeakerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Data.Speaker>> ListAsync()
        {
            return _dbContext.Speakers.AsNoTracking()
                             .Include(s => s.SessionSpeakers)
                                 .ThenInclude(ss => ss.Session).ToListAsync();
        }
    }
}
