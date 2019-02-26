using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPFEntityF.MyEntities
{
   public class Text
    {
        public int Id { get; set; }

        public string TextValue { get; set; }
        
        public virtual Message Message { get; set; }

    }
}
