using ChatWPFEntityF.MyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPFEntityF
{
    public class Message
    {
        public int Id { get; set; }
        public virtual ICollection<Text> Texts { get; set;}

    public virtual ICollection<Sender> Senders { get; set; } 

      public virtual ICollection <Reciever> Recievers { get; set; }
    }
}
