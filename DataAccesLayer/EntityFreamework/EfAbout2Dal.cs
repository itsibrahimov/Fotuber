﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFreamework
{
    public class EfAbout2Dal : GenericRepository<About2>, IAbout2Dal
    {
    }
}
