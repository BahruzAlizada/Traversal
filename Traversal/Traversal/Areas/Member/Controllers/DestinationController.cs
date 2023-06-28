using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Traversal.Areas.Member.Controllers
{
	[Area("Member")]
	public class DestinationController : Controller
	{
		DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
		public async Task<IActionResult> Index()
		{
			List<Destination> destination = await destinationManager.GetListAsync();
			List<Destination> destinationslimit = destination.Where(x=>!x.IsDeactive).OrderByDescending(x=>x.Id).ToList();
			return View(destinationslimit);
		}
	}
}
