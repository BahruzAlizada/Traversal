using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.IO;
using System.Threading.Tasks;
using Traversal.Helpers;
using Traversal.ViewsModel;

namespace Traversal.Areas.Member.Controllers
{
	[Area("Member")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;
		public ProfileController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager,IWebHostEnvironment env)
		{
            _env = env;
            _signInManager = signInManager;
			_userManager = userManager;
		}
        #region Index
        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            MemberVM member = new MemberVM
            {
                Image=user.Image,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Phone = user.PhoneNumber,
                Username = user.UserName
            };
         
            return View(member);
        }
            
        #endregion

        #region Update
        public async Task<IActionResult> Update()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            UpdateMemberVM dbupdateMember = new UpdateMemberVM
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Phone = user.PhoneNumber,
                Username = user.UserName
            };
            return View(dbupdateMember);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(UpdateMemberVM updateMember)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (updateMember.Photo != null)
            {
                #region Image
                if (updateMember.Photo != null)
                {
                    if (!updateMember.Photo.IsImage())
                    {
                        ModelState.AddModelError("Photo", "Select Image Type");
                        return View();
                    }
                    if (updateMember.Photo.IsOlder512kb())
                    {
                        ModelState.AddModelError("Photo", "Max 512Kb");
                        return View();
                    }
                    string folder = Path.Combine(_env.WebRootPath, "member", "assets", "img", "user");
                    updateMember.Image = await updateMember.Photo.SaveFileAsync(folder);
                    string path = Path.Combine(_env.WebRootPath, folder, user.Image);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    user.Image = updateMember.Image;
                }
                #endregion
            }
            user.Name = updateMember.Name;
            user.Surname = updateMember.Surname;
            user.Email = updateMember.Email;
            user.UserName = updateMember.Username;
            user.PhoneNumber = updateMember.Phone;


            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return RedirectToAction("Index","Profile");
        }
        #endregion

        #region ChangePassword
        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            UpdateMemberVM dbchangepassword = new UpdateMemberVM
            {
                Username = user.UserName
            };
            return View(dbchangepassword);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> ChangePassword(UpdateMemberVM changePassword)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            UpdateMemberVM dbchangepassword = new UpdateMemberVM
            {
                Username = user.UserName
            };
            bool isPasswordValid = await _userManager.CheckPasswordAsync(user, changePassword.OldPassword); // Əvvəlki şifrəni tapırıq
            if (isPasswordValid) // Əgər əvvəlki şifrəni düzgün yazıbsa if-in içindəkilər olur
            {
                string newPasswordHash  = _userManager.PasswordHasher.HashPassword(user,changePassword.NewPassword); //Yeni şifrəni alırıq
                user.PasswordHash = newPasswordHash; //Userin passvordhas-na bərabər edirik.
                var result = await _userManager.UpdateAsync(user); //UpdateEdirik
                if (!result.Succeeded) // Əgər hər hansısa səhv olsa bunu bizə bilidr
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
                await _signInManager.SignOutAsync(); //Əgər şifrə dəyişsə hesabdan çıxış et və Login səhifəsinə dön
                return RedirectToAction("Login", "Account", new { area = "default" });
            }
            else //Əgər ki köhnə şifrəni düzgün qeyd etməyibsə index-də bir xəta mesajı göndər
            {
                ModelState.AddModelError("OldPassword", "Wrong Password !");
                return View();
            }
        }
        #endregion

    }
}
