using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        ReservationManager reservationManager = new ReservationManager(new EFReservationDal());

        private readonly UserManager<AppUser> _userManager;
        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Destination> destination = await destinationManager.GetListAsync();
            List<Destination> destinationslimit = destination.Where(x => !x.IsDeactive).OrderByDescending(x => x.Id).ToList();
            return View(destinationslimit);
        }
        #endregion

        #region Reservation
        public async Task<IActionResult> Reservation(int? id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (id == null)
                return BadRequest();
            Destination destination = await destinationManager.GetByIdAsync(id);
            if (destination == null)
                return BadRequest();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Reservation(Reservation reservation, int? id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (id == null)
                return NotFound();
            Destination destination = await destinationManager.GetByIdAsync(id);
            if (destination == null)
                return NotFound();

            #region Person Count
            if (reservation.PersonCount <= 0)
            {
                ModelState.AddModelError("PersonCount", "Person Count 0-6");
                return View();
            }
            if (reservation.PersonCount > 6)
            {
                ModelState.AddModelError("PersonCount", "Person Count 0-6");
                return View();
            }
            #endregion

            reservation.AppUserId = user.Id;
            reservation.DestinationnId = destination.Id;
            destination.Capacity = destination.Capacity - reservation.PersonCount;

            await reservationManager.TAddasync(reservation);

            string subject = $"From Baku To  {destination.City}";
            string message = $"Sizə {destination.City}-də xoş istirahətlər arzulayırıq !" +
                $"Sizin üçün {destination.CreatedTime.ToShortDateString()} tarixindəki səfər üçün {reservation.PersonCount} dənə bilet ayrılmışdır." +
                $"Biletlərin toplam qiyməti ${destination.Price * reservation.PersonCount} Azn-dır." +
                $"Növbəti səfərlərinizi bizim ilə planlamağı unutmayın )" +
                $"Hörmətlə Admin-Traversal.";

            await Helpers.EmailSend.SendMailAsync(subject, message, user.Email);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
