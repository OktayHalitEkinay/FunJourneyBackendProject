using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Admin: IEntity
    {
        public byte AdminId { get; set; }//birincil anahtar
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }


    }
}
