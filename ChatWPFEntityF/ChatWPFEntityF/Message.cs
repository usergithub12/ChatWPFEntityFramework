﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPFEntityF
{
   public class Message
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public DateTime DateSend { get; set; }
      
    }
}
