using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlaceDal : EfEntityRepositoryBase<Place, FunJourneyContext>, IPlaceDal
    {
        public List<PlaceDetailDto> GetPlaceDetails(Expression<Func<PlaceDetailDto, bool>> filter = null)
        {
            using (FunJourneyContext context = new FunJourneyContext())
            {
                if (filter == null)
                {
                    var result = from pl in context.Tbl_Places
                                 join c in context.Tbl_Categories on pl.CategoryId equals c.CategoryId
                                 join pr in context.Tbl_Provinces on pl.ProvinceId equals pr.ProvinceId
                                 join im in context.Tbl_PlaceImages on pl.PlaceImageId equals im.PlaceImageId
                                 select new PlaceDetailDto
                                 {
                                     PlaceId = pl.PlaceId,
                                     CategoryId = pl.CategoryId,
                                     PlaceName = pl.PlaceName,
                                     PlaceInformation = pl.PlaceInformation,
                                     AddressDescription = pl.AddressDescription,
                                     CategoryName = c.CategoryName,
                                     ProvinceName = pr.ProvinceName,
                                     PlaceImageName = im.PlaceImageName
                                 };

                    return result.ToList();
                }
                else
                {
                    {
                        var result = from pl in context.Tbl_Places
                                     join c in context.Tbl_Categories on pl.CategoryId equals c.CategoryId
                                     join pr in context.Tbl_Provinces on pl.ProvinceId equals pr.ProvinceId     
                                     join im in context.Tbl_PlaceImages on pl.PlaceImageId equals im.PlaceImageId
                                     select new PlaceDetailDto
                                     {
                                         PlaceId = pl.PlaceId,
                                         CategoryId=pl.CategoryId,
                                         PlaceName = pl.PlaceName,
                                         PlaceInformation = pl.PlaceInformation,
                                         AddressDescription = pl.AddressDescription,
                                         CategoryName = c.CategoryName,
                                         ProvinceName = pr.ProvinceName,
                                         PlaceImageName=im.PlaceImageName
                                     };
                        return result.Where(filter).ToList();
                    }
                }



            }




        }


     
    }
}
