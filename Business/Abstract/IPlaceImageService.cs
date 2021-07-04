using Core.Utilities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlaceImageService
    {
        IDataResult<List<PlaceImage>> GetAll();
        IDataResult<List<PlaceImage>> GetImagesByPlaceId(Int16 placeId);
        IDataResult<List<PlaceImage>> GetCategoryImageByCategoryId(short categoryId);
    }
}
