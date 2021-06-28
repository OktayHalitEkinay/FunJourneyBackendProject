using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // DtoTest();
            //AddPlaceTest();            
            //DeletePlaceTest();
            //UpdatePlaceTest();
            GetPlaceByChooseTest();

        }

        private static void GetPlaceByChooseTest()
        {
            EfPlaceDal efPlaceDal = new EfPlaceDal();
            PlaceManager placeManager = new PlaceManager(efPlaceDal);
            var result = placeManager.GetPlaceByChoose(2, 2);
            if (result.Success == true)
            {
                foreach (var place in result.Data)
                {
                    Console.WriteLine(place.PlaceId + "/" + place.PlaceName + "/");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UpdatePlaceTest()
        {
            Place place = new Place();
            EfPlaceDal efPlaceDal = new EfPlaceDal();
            PlaceManager placeManager = new PlaceManager(efPlaceDal);
            placeManager.Update(new Place
            {
                PlaceId = 5,
                PlaceName = "Şeyh Edebali Türbesi"
            }); ; ;
        }

        private static void DeletePlaceTest()
        {
            Place place = new Place();
            EfPlaceDal efPlaceDal = new EfPlaceDal();
            PlaceManager placeManager = new PlaceManager(efPlaceDal);
            placeManager.Delete(new Place
            {
                PlaceId=14,
            }); ;
        }

        private static void AddPlaceTest()
        {
            Place place = new Place();
            EfPlaceDal efPlaceDal = new EfPlaceDal();
            PlaceManager placeManager = new PlaceManager(efPlaceDal);

            placeManager.Add(new Place
            {
                ProvinceId = 1,
                CategoryId = 2,
                PlaceName = "Köfteci Yusuf",
            });
        }

        private static void DtoTest()
        {
            EfPlaceDal efPlaceDal = new EfPlaceDal();
            PlaceManager placeManager = new PlaceManager(efPlaceDal);

            var result = placeManager.GetPlaceDetails();
            if (result.Success == true)
            {
                foreach (var place in result.Data)
                {
                    Console.WriteLine( place.PlaceId+ "/" + place.PlaceName + "/" + place.ProvinceName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}
