using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TheFluffyPetApi.Models;

namespace TheFluffyPetApi.controllers
{
    [ApiController]
    [Route("api/cats")]
    public class CatsController : ControllerBase
    {
        static readonly List<Cat> cats = [];

        public CatsController()
        {
            AddCat(new Cat
            {
                CatId = "c001",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c002",
                Name = "Mao mao",
                Breed = "xiêm",
                Gender = true,
                Age = 1,
                Color = "trắng",
                BirthDate = new DateOnly(2024, 6, 1),
                Weight = 3f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new(2024, 7, 1), new(2024, 9, 1)],
                Price = 700000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://furmily.vn/wp-content/uploads/2023/11/Thiet-ke-chua-co-ten-5-1.jpg",
                    "https://www.petmart.vn/wp-content/uploads/2019/04/meo-xiem.jpg",
                    "https://zoipet.com/wp-content/uploads/2020/04/meo-xiem.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c003",
                Name = "harry",
                Breed = "Persian",
                Gender = true,
                Age = 2,
                Color = "golden",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new(2023, 6, 1), new(2023, 7, 1)],
                Price = 12000000,
                Description = "A fluffy Persian cat.",
                ImageUrls =
                [
                    "https://cdn.pixabay.com/photo/2017/08/23/08/33/cats-2671249_1280.jpg",
                    "https://cdn.pixabay.com/photo/2020/04/07/16/01/cat-5013356_1280.jpg",
                    "https://cdn.pixabay.com/photo/2015/11/15/22/09/cat-1044750_1280.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c004",
                Name = "chuột",
                Breed = "Persian",
                Gender = true,
                Age = 2,
                Color = "golden",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 900000,
                Description = "A fluffy Persian cat.",
                ImageUrls =
                [
                    "https://cdn.pixabay.com/photo/2017/11/09/21/41/cat-2934720_1280.jpg",
                    "https://cdn.pixabay.com/photo/2017/11/14/13/06/kitty-2948404_1280.jpg",
                    "https://cdn.pixabay.com/photo/2014/04/13/20/49/cat-323262_1280.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c005",
                Name = "Luna",
                Breed = "Scottish Fold",
                Gender = false,
                Age = 1,
                Color = "gray",
                BirthDate = new DateOnly(2023, 8, 15),
                Weight = 3.8f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates = [new(2023, 9, 15), new(2023, 10, 15)],
                Price = 15000000,
                Description = "Adorable Scottish Fold with folded ears",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2017/11/14/13/06/kitty-2948404_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/11/04/33/cat-4617248_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/11/09/21/41/cat-2934720_1280.jpg"
    ],
                Discount = 5
            });
            AddCat(new Cat
            {
                CatId = "c006",
                Name = "Sushi",
                Breed = "Ragdoll",
                Gender = false,
                Age = 1,
                Color = "white and brown",
                BirthDate = new DateOnly(2023, 7, 20),
                Weight = 5.2f,
                HealthStatus = "Good",
                IsDeworming = true,
                VaccinateDates = [new(2023, 8, 20), new(2023, 9, 20)],
                Price = 18000000,
                Description = "Gentle and affectionate Ragdoll cat",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2017/03/14/14/49/cat-2143332_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/01/28/12/37/cat-3113422_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/27/17/25/cat-3266673_1280.jpg"
    ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c007",
                Name = "Oreo",
                Breed = "American Shorthair",
                Gender = true,
                Age = 3,
                Color = "black and white",
                BirthDate = new DateOnly(2021, 6, 10),
                Weight = 4.7f,
                HealthStatus = "Good",
                IsDeworming = true,
                VaccinateDates = [new(2021, 7, 10), new(2021, 8, 10), new(2022, 7, 10)],
                Price = 8000000,
                Description = "Playful American Shorthair with tuxedo pattern",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2015/11/16/14/43/cat-1045782_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/02/20/18/03/cat-2083492_1280.jpg",
        "https://cdn.pixabay.com/photo/2014/04/13/20/49/cat-323262_1280.jpg"
    ],
                Discount = 10
            });
            AddCat(new Cat
            {
                CatId = "c008",
                Name = "Mochi",
                Breed = "Maine Coon",
                Gender = false,
                Age = 2,
                Color = "brown tabby",
                BirthDate = new DateOnly(2022, 4, 5),
                Weight = 6.5f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates = [new(2022, 5, 5), new(2022, 6, 5), new(2023, 5, 5)],
                Price = 25000000,
                Description = "Majestic Maine Coon with stunning coat",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/03/14/14/49/cat-2143332_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/27/17/25/cat-3266673_1280.jpg"
    ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c009",
                Name = "Milo",
                Breed = "Bengal",
                Gender = true,
                Age = 1,
                Color = "spotted brown",
                BirthDate = new DateOnly(2023, 9, 1),
                Weight = 4.2f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates = [new(2023, 10, 1), new(2023, 11, 1)],
                Price = 30000000,
                Description = "Energetic Bengal with exotic markings",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2017/11/09/21/41/cat-2934720_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/11/14/13/06/kitty-2948404_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg"
    ],
                Discount = 0
            });

            AddCat(new Cat
            {
                CatId = "c010",
                Name = "Kitty",
                Breed = "Exotic Shorthair",
                Gender = false,
                Age = 1,
                Color = "cream",
                BirthDate = new DateOnly(2023, 10, 15),
                Weight = 3.8f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates = [new(2023, 11, 15), new(2024, 1, 15)],
                Price = 16000000,
                Description = "Sweet and gentle Exotic Shorthair kitten",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2014/11/30/14/11/cat-551554_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/02/25/17/56/cat-649164_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/29/01/10/adorable-1866475_1280.jpg"
    ],
                Discount = 5
            });

            AddCat(new Cat
            {
                CatId = "c011",
                Name = "Shadow",
                Breed = "Russian Blue",
                Gender = true,
                Age = 2,
                Color = "blue-gray",
                BirthDate = new DateOnly(2022, 8, 20),
                Weight = 4.2f,
                HealthStatus = "Good",
                IsDeworming = true,
                VaccinateDates = [new(2022, 9, 20), new(2023, 9, 20)],
                Price = 22000000,
                Description = "Elegant Russian Blue with plush double coat",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2019/05/08/21/21/cat-4189697_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/03/28/12/35/cat-1285634_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/03/27/13/16/cat-694730_1280.jpg"
    ],
                Discount = 0
            });

            AddCat(new Cat
            {
                CatId = "c012",
                Name = "Mocha",
                Breed = "British Shorthair",
                Gender = false,
                Age = 1,
                Color = "chocolate",
                BirthDate = new DateOnly(2023, 11, 5),
                Weight = 3.5f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates = [new(2023, 12, 5), new(2024, 2, 5)],
                Price = 18000000,
                Description = "Charming British Shorthair with chocolate coat",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2017/02/15/12/12/cat-2068462_1280.jpg",
        "https://cdn.pixabay.com/photo/2014/04/13/20/49/cat-323262_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/11/16/14/43/cat-1045782_1280.jpg"
    ],
                Discount = 8
            });

            AddCat(new Cat
            {
                CatId = "c013",
                Name = "Snowball",
                Breed = "Ragdoll",
                Gender = false,
                Age = 1,
                Color = "white and seal point",
                BirthDate = new DateOnly(2023, 12, 10),
                Weight = 4.0f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates = [new(2024, 1, 10), new(2024, 2, 10)],
                Price = 25000000,
                Description = "Beautiful Ragdoll kitten with blue eyes",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2017/02/20/18/03/cat-2083492_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/29/01/10/adorable-1866475_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/02/25/17/56/cat-649164_1280.jpg"
    ],
                Discount = 0
            });

            AddCat(new Cat
            {
                CatId = "c014",
                Name = "Tiger",
                Breed = "Bengal",
                Gender = true,
                Age = 2,
                Color = "brown spotted tabby",
                BirthDate = new DateOnly(2022, 6, 15),
                Weight = 5.0f,
                HealthStatus = "Good",
                IsDeworming = true,
                VaccinateDates = [new(2022, 7, 15), new(2023, 7, 15)],
                Price = 35000000,
                Description = "Active and playful Bengal with exotic markings",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/11/14/13/06/kitty-2948404_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/05/08/21/21/cat-4189697_1280.jpg"
    ],
                Discount = 10
            });

            AddCat(new Cat
            {
                CatId = "c015",
                Name = "Leo",
                Breed = "Maine Coon",
                Gender = true,
                Age = 3,
                Color = "red tabby",
                BirthDate = new DateOnly(2021, 4, 1),
                Weight = 8.5f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates = [new(2021, 5, 1), new(2022, 5, 1), new(2023, 5, 1)],
                Price = 28000000,
                Description = "Majestic Maine Coon with impressive size",
                ImageUrls =
    [
        "https://cdn.pixabay.com/photo/2018/03/27/17/25/cat-3266673_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/03/14/14/49/cat-2143332_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/11/16/14/43/cat-1045782_1280.jpg"
    ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c016",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c017",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c018",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c019",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c020",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c021",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c022",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c023",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c024",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c025",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c026",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c027",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c028",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c029",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c030",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrls =
                [
                    "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                    "https://azpet.com.vn/wp-content/uploads/2021/07/meo-anh-long-ngan-2.jpg",
                    "https://meocunpet.com/wp-content/uploads/2020/07/meo-anh-long-ngan-mau-xam-xanh.jpg"
                ],
                Discount = 0
            });
        }

        [HttpGet]
        public IActionResult GetAllCats([FromQuery] int? limit)
        {
            if (limit.HasValue && limit.Value > 0)
            {
                return Ok(cats.Take(limit.Value));
            }
            return Ok(cats);
        }

        [HttpGet("{id}")]
        public IActionResult GetCat(string id)
        {
            Cat? cat = cats.FirstOrDefault(c => c.CatId == id);
            if (cat == null)
            {
                return NotFound($"Cat with id {id} not found.");
            }
            return Ok(cat);
        }

        [HttpPost]
        public IActionResult AddCat(Cat cat)
        {
            if (cats.Any(c => c.CatId == cat.CatId))
            {
                return Conflict($"Cat with id {cat.CatId} already exists.");
            }

            cats.Add(cat);
            return CreatedAtAction(nameof(GetCat), new { id = cat.CatId }, cat);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCat(string id, Cat updatedCat)
        {
            Cat? existingCat = cats.FirstOrDefault(c => c.CatId == id);
            if (existingCat == null)
            {
                return NotFound($"Cat with id {id} not found.");
            }

            existingCat.Name = updatedCat.Name;
            existingCat.Breed = updatedCat.Breed;
            existingCat.Price = updatedCat.Price;
            existingCat.Description = updatedCat.Description;
            existingCat.ImageUrls = updatedCat.ImageUrls;

            return NoContent();
        }
    }
}