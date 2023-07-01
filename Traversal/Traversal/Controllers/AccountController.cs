using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using System.Threading.Tasks;
using Traversal.ViewsModel;

namespace Traversal.Controllers
{
	[AllowAnonymous]
	public class AccountController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;
		private readonly RoleManager<AppRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager,
			RoleManager<AppRole> roleManager)
        {
			_roleManager=roleManager;
			_userManager = userManager;
			_signInManager = signInManager;
        }

		#region Login
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(LoginVM loginVM)
		{
			AppUser user = await _userManager.FindByEmailAsync(loginVM.Email);
			if (user == null)
			{
				ModelState.AddModelError("", "UserName or Password is wrong");
				return View();
			}
			if (user.IsDeactive)
			{
				ModelState.AddModelError("", "Your Account is deactive");
				return View();
			}
			Microsoft.AspNetCore.Identity.SignInResult sign = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.IsRemember, true);
			if (sign.IsLockedOut)
			{
				ModelState.AddModelError("", "Your account is blocked");
				return View();
			}
			if (!sign.Succeeded)
			{
				ModelState.AddModelError("", "Email or password is wrong");
				return View();
			}
			return RedirectToAction("Index", "Home", new { Area = "default" });
		}
		#endregion

		#region Register
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Register(RegisterVM registerVM)
		{
			AppUser user = new AppUser
			{
				Image = "wwwroot/member/assets/img/user/user.png",
				Name = registerVM.Name,
				Surname = registerVM.Surname,
				Email = registerVM.Email,
				UserName = registerVM.Username,
				PhoneNumber = registerVM.PhoneNumber,
				CreatedTime = registerVM.CreateTime
			};
			IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);
			if (!result.Succeeded)
			{
				foreach (IdentityError error in result.Errors)
				{
					ModelState.AddModelError("", error.Description);
				}
				return View();
			}
			await _signInManager.SignInAsync(user, registerVM.IsRemember);
			await _userManager.AddToRoleAsync(user, AppRole.MemberRole);

			return RedirectToAction("Index", "Home");
		}
		#endregion

		#region LogOut
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home", new { Area = "default" });
		}
		#endregion
	}
}
