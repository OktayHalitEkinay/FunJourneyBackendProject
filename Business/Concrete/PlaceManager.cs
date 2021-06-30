using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlaceManager : IPlaceService
    {
        IPlaceDal _placeDal;

        public PlaceManager(IPlaceDal placeDal)
        {
            _placeDal = placeDal;
        }

        public IDataResult<List<Place>> GetAll()
        {
            return new DataResult<List<Place>>(_placeDal.GetAll(),true,"Bütün mekanlar listelendi.");                
        }
 
        public IDataResult<List<Place>> GetPlaceByChoose(Int16 CategoryId, Int16 ProvinceId)
        {
            return new DataResult<List<Place>>(_placeDal.GetAll(p => p.CategoryId == CategoryId && p.ProvinceId == ProvinceId), true);
        }

        public IDataResult<List<Place>> GetPlaceCategoryId(short categoryId)
        {
            return new DataResult<List<Place>>(_placeDal.GetAll(p => p.CategoryId ==categoryId), true,"Mekanlar kategori Id'ye göre Listelendi.");
        }
        public IDataResult<List<Place>> GetPlaceProvinceId(short provinceId)
        {
            return new DataResult<List<Place>>(_placeDal.GetAll(p => p.ProvinceId == provinceId), true, "Mekanlar kategori Id'ye göre Listelendi.");
        }


        /*DtoS*/
        public IDataResult<List<PlaceDetailDto>> GetPlaceDetailsByPlaceId(short placeId)
        {
            return new DataResult<List<PlaceDetailDto>>(_placeDal.GetPlaceDetails(p => p.PlaceId == placeId),true);
        }

        public IDataResult<List<PlaceDetailDto>> GetPlaceDetails()
        {
            return new DataResult<List<PlaceDetailDto>>(_placeDal.GetPlaceDetails(),true);
        }

        public IDataResult<List<PlaceDetailDto>> GetPlaceDetailsByCategoryId(short categoryId)
        {
            return new DataResult<List<PlaceDetailDto>>(_placeDal.GetPlaceDetails(p => p.CategoryId== categoryId), true);
        }

        /*DtoS*/


        /******************CRUD********************/
        public IResult Add(Place place)
        {

            if (place.PlaceName.Length < 2)
            {
                return new ErrorResult(Messages.PlaceNameInvalid);
            }
            _placeDal.Add(place);
            return new SuccessResult(Messages.PlaceAdded);
        }

        public IResult Delete(Place place)
        {
            _placeDal.Delete(place);
            return new SuccessResult(Messages.PlaceDeleted);

        }
        public IResult Update(Place place)
        {
            _placeDal.Update(place);
            return new SuccessResult(Messages.PlaceUpdated);
        }
        /******************CRUD********************/

    }
}
