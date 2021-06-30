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

        public Int16 PlaceId { get; set; }//Birincil Anahtar
        public Int16 CategoryId { get; set; }//İlişkisel Anahtar
        public Int16 ProvinceId { get; set; }//İlişkisel Anahtar
        public Int16 PlaceImageId { get; set; } //İlişkisel Anahtar
        public string PlaceName { get; set; }
        public string AddressDescription { get; set; }
        public string  PlaceInformation { get; set; }
    }
}
