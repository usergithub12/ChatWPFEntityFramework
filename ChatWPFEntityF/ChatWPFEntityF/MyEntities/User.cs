using ChatWPFEntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPFEntityF
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public virtual Sender Sender { get; set; }

        public string UserPhotoPath { get; set; }

      


    }
}
