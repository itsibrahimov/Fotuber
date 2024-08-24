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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithService()
        {
            using(var c = new Context())
            {
                return c.Comments.Include(x => x.Service).ToList();
            }
        }
    }
}
