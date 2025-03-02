﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GettListWithReservationByWaitAprroval(int id);
        List<Reservation> GettListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
    }
}
