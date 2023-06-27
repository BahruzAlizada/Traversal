using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents
{
    public class TeamViewComponent : ViewComponent
    {
        TeamManager teamManager = new TeamManager(new EFTeamDal());

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Team> teams = await teamManager.GetListAsync();
            List<Team> teamlimit = teams.Take(4).ToList();
            return View(teams);
        }
    }
}
