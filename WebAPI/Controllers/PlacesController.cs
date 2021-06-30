using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        IPlaceService _placeService;

        public PlacesController(IPlaceService placeService)
        {
            _placeService = placeService;
        }
       
        [HttpGet("getallplaces")]
        public IActionResult GetAllPlaces()
        {
            var result = _placeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getplacecategoryId")]
        public IActionResult GetPlaceCategoryId(Int16 CategoryId)
        {
            var result = _placeService.GetPlaceCategoryId(CategoryId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getplaceprovinceId")]
        public IActionResult GetPlaceProvinceId(Int16 ProvinceId)
        {
            var result = _placeService.GetPlaceProvinceId(ProvinceId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpGet("getplacechoose")]
        public IActionResult GetPlaceChoose(Int16 CategoryId, Int16 ProvinceId)
        {
            var result = _placeService.GetPlaceByChoose(CategoryId,ProvinceId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

     

   


        /*DTOs*/
        [HttpGet("GetPlaceDetails")]
        public IActionResult GetPlaceDetails()
        {
            var result = _placeService.GetPlaceDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetPlaceDetailsByPlaceId")]
        public IActionResult GetPlaceDetailsPlaceId(Int16 placeId)
        {
            var result = _placeService.GetPlaceDetailsByPlaceId(placeId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetPlaceDetailsByCategoryId")]
        public IActionResult GetPlaceDetailsCategoryId(Int16 categoryId)
        {
            var result = _placeService.GetPlaceDetailsByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        /*DTOs*/







        /*CRUD*/
        [HttpPost("addplace")]
        public IActionResult AddPlace(Place place)
        {
            var result = _placeService.Add(place);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updateplace")]
        public IActionResult UpdateCar(Place place)
        {
            var result = _placeService.Update(place);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("deleteplace")]
        public IActionResult DeleteCar(Place place)
        {
            var result = _placeService.Delete(place);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        /*CRUD*/

    }
}
