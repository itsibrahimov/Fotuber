using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommenContent { get; set; }
        public bool CommenState { get; set; }
        public int ServiceID { get; set; }
        public Service Service { get; set; }
    }
}
