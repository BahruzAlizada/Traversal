using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal=reservationDal;
        }
        public Task<Reservation> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reservation>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task TAddasync(Reservation t)
        {
            await _reservationDal.InsertAsync(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
