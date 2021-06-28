using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Place : IEntity
    {

        public Int16 PlaceId { get; set; }//birincil anahtar
        public Int16 CategoryId { get; set; }//İlişkisel anahtar
        public Int16 ProvinceId { get; set; }//İlişkisel Anahtar
        public string PlaceName { get; set; }

    }
}
