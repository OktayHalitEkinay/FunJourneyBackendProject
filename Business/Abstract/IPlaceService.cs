using Core.Utilities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlaceService
    {
         IDataResult<List<Place>> GetAll();
         IDataResult<List<Place>> GetPlaceByChoose(Int16 CategoryId,Int16 ProvinceId);
         IDataResult<List<Place>> GetPlaceCategoryId(short categoryId);
         IDataResult<List<Place>> GetPlaceProvinceId(short provinceId);
         IDataResult<List<PlaceDetailDto>> GetPlaceDetails();
         
         


         IResult Add(Place place);
         IResult Update(Place place);
         IResult Delete(Place place);
        
    }
}
