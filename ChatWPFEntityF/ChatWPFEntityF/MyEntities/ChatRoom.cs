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
        public virtual Reciever Reciever { get; set; }
        public virtual Sender Sender { get; set; }
    }
}
