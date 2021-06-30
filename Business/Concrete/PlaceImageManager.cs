using Business.Abstract;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlaceImageManager : IPlaceImageService
    {
        IPlaceImageDal _placeImageDal;

        public PlaceImageManager(IPlaceImageDal placeImageDal)
        {
            _placeImageDal = placeImageDal;
        }

        public IDataResult<List<PlaceImage>> GetAll()
        {
            return new DataResult<List<PlaceImage>>(_placeImageDal.GetAll(),true);
        }

        public IDataResult<PlaceImage> GetById(short placeImageId)
        {
            return new DataResult<PlaceImage>(_placeImageDal.Get(pi => pi.PlaceImageId == placeImageId),true);
        }

        public IDataResult<List<PlaceImage>> GetImagesByPlaceId(short placeId)
        {
            return new DataResult<List<PlaceImage>>(_placeImageDal.GetAll(pi => pi.PlaceId== placeId), true);
        }
    }
}
