using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PlaceImage:IEntity
    {
        public Int16 PlaceImageId { get; set; }
        public string PlaceImageName { get; set; }
        public Int16 PlaceId { get; set; }
        public Int16 CategoryId { get; set; }
        public string CategoryImageName { get; set; }
    }
}
