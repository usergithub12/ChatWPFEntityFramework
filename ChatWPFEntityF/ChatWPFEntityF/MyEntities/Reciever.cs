using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPFEntityF.MyEntities
{
   public class Reciever
    {
        public int Id { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
