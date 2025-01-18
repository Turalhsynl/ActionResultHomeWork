using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Homepage";
        }

        public ViewResult Drinks1()
        {
            List<Drinks> drinks = new List<Drinks>()
            {
                new Drinks()
                {
                    Id = 1,
                    Name = "Coca-Cola",
                    Price = 3
                },
                new Drinks()
                {
                    Id = 2,
                    Name = "Red-Bull",
                    Price = 10
                },
                new Drinks()
                {
                    Id = 1,
                    Name = "Ayran",
                    Price = 0.5
                }
            };
            return View(drinks);
        }

        public ViewResult FastFoods1()
        {
            List<FastFoods> fastFoods = new List<FastFoods>()
            {
                new FastFoods()
                {
                    Id= 1,
                    Name = "Burger",
                    Price= 14
                },
                new FastFoods()
                {
                    Id= 2,
                    Name = "Pizza",
                    Price= 20
                },
                new FastFoods()
                {
                    Id= 3,
                    Name = "Doner",
                    Price= 3
                },
            };

            return View(fastFoods);
        }

        public ViewResult HotMeals()
        {
            List<HotMeals> hotMeals = new List<HotMeals>()
            {
                new HotMeals()
                {
                    Id = 1,
                    Name = "Dolma",
                    Price = 100
                },
                new HotMeals()
                {
                    Id = 2,
                    Name = "Bozbas",
                    Price= 20
                },
                new HotMeals()
                {
                    Id = 3,
                    Name = "Plov",
                    Price= 25
                }
            };

            return View(hotMeals);
        }
    }
}
