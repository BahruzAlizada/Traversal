﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Member.Controllers
{
	[Area("Member")]
	public class ProfileController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
