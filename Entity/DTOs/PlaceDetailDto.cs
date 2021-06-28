using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PlaceDetailDto:IDto
    {
        public Int16 PlaceId { get; set; }
        public string ProvinceName { get; set; }
        public string CategoryName { get; set; }
        public string PlaceName { get; set; }
    }
}
