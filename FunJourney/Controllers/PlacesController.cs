using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunJourney.Controllers
{
    public class PlacesController : Controller
    {

        [HttpGet]
        public List<Place> Get()
        {
            IPlaceService placeService = new PlaceManager(new EfPlaceDal());
            var result = placeService.GetAll();
            return result.Data;
        }
       
    }
}
