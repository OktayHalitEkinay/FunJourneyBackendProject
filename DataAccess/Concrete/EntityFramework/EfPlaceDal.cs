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
        
        public List<PlaceDetailDto> GetPlaceDetails()
        {
            using (FunJourneyContext context=new FunJourneyContext())
            {
                var result = from pl in context.Tbl_Places
                             join c in context.Tbl_Categories on pl.CategoryId equals c.CategoryId
                             join pr in context.Tbl_Provinces on pl.ProvinceId equals pr.ProvinceId
                             select new PlaceDetailDto
                             {
                                 PlaceId = pl.PlaceId,
                                 PlaceName = pl.PlaceName,
                                 CategoryName = c.CategoryName,
                                 ProvinceName = pr.ProvinceName
                             };

                return result.ToList();
            }
        }
    }
}
