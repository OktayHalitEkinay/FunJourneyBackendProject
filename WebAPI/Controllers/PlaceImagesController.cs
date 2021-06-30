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
    public class PlaceImagesController : ControllerBase
    {
        IPlaceImageService _placeImageService;

        public PlaceImagesController(IPlaceImageService placeImageService)
        {
            _placeImageService = placeImageService;
        }


        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    var result = _placeImageService.GetAll();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpGet("getbyId")]
        public IActionResult GetById(Int16 placeImageId)
        {
            var result = _placeImageService.GetById(placeImageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagesbyplaceId")]
        public IActionResult GetImagesByPlaceId(Int16 placeId)
        {
            var result = _placeImageService.GetImagesByPlaceId(placeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAllImages")]
        public IActionResult GetAllImages()
        {
            var result = _placeImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }
}
