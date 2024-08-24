using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFreamework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Service).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GettListWithReservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Service).Where(x => x.Status == "Rezervasyon Onaylandı" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GettListWithReservationByWaitAprroval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Service).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToList();
            }

        }
    }
}
