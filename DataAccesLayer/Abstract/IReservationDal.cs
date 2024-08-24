using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GettListWithReservationByWaitAprroval(int id);
        List<Reservation> GettListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
    }
}
