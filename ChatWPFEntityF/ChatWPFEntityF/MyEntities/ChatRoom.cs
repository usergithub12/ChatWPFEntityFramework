using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPFEntityF.MyEntities
{
   public class ChatRoom
    {
        public int Id { get; set; }
        public virtual ICollection< Reciever> Recievers { get; set; }
        public virtual ICollection<Sender> Senders { get; set; }
    }
}
