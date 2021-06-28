using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Province : IEntity
    {
        public Int16 ProvinceId { get; set; }//Birincil anahtar
        public string ProvinceName { get; set; }

    }
}
