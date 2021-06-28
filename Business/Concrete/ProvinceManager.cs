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
    public class ProvinceManager : IProvinceService
    {
        IProvinceDal _provinceDal;

        public ProvinceManager(IProvinceDal provinceDal)
        {
            _provinceDal = provinceDal;
        }

        public IDataResult<List<Province>> GetAll()
        {
            return new DataResult<List<Province>>(_provinceDal.GetAll(), true,"İller listelendi.");
        }

    }
}
