﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPFEntityF
{
   public class Sender
    {
        public int id { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ChatRoom Chat { get; set; }
    }
}
