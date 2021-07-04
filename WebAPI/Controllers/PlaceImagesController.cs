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

        [HttpGet("getimagesbycategoryId")]
        public IActionResult GetImagesByCategoryId(Int16 categoryId)
        {
            var result = _placeImageService.GetCategoryImageByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





    }
}
