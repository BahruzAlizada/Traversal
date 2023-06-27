using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            _teamDal=teamDal;
        }
        public Task<Team> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Team>> GetListAsync()
        {
            using var c = new Context();
            return await c.Set<Team>().ToListAsync();
        }

        public Task TAddasync(Team t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Team t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Team t)
        {
            throw new NotImplementedException();
        }
    }
}
