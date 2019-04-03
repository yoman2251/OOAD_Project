using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IronmenMvcWeb.Models;




namespace IronmenMvcWeb.Controllers
{
    public class HomeController : Controller
    {
        //        public object pokemons = new List<Pokemon>();
        public List<Pokemon> _pokemons;
        public List<Pokemon> pokemons {
            get {
                if (this._pokemons == null)
                    this._pokemons = new List<Pokemon>();
                return this._pokemons;
            }
        }
    
        //public object Pokemons { get => pokemons; set => pokemons = value; }

        public IActionResult Index() // Index 的 Controller
        {
            /*
            var pokemon = new Pokemon()
            {
                Id= 1,
                Name = "RS",
                Property = "anal"
            };
            */

            /*
            var pokemons = new List<Pokemon>()
            {
                
                new Pokemon()
                {
                    Title = "Paper1",
                    Author = "水箭龜",
                    PublishDate = "水系",
                    Source = "123",
                },

                new Pokemon()
                {
                    Title = "Paper2",
                    Author = "噴火龍",
                    PublishDate = "火系",
                    Source = "123",
                },

                new Pokemon()
                {
                    Title = "Paper3",
                    Author = "妙蛙花",
                    PublishDate = "草系",
                    Source = "123",
                }
                
            };
            */

            var a = new Pokemon()
            {
                Title = "Paper3",
                Author = "妙蛙花",
                PublishDate = "草系",
                Source = "1234",
            };
            // pokemons.Append<Pokemon>(a);
            pokemons.Add(a);
            pokemons.Add(a);


            // return View(pokemon);
            return View(pokemons);
        }

        public IActionResult About() // About 的 Controller
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() // Contact 的 Controller
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Account()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Account(Account account)
        {
            if (ModelState.IsValid)
            {
                //Create book.
            }
            return View();
        }

        [HttpGet]
        public IActionResult Report()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Report(Report report)
        {
            if (ModelState.IsValid)
            {
                var a = new Pokemon()
                {
                    Title = "Paper3",
                    Author = "妙蛙花",
                    PublishDate = "草系",
                    Source = "1234",
                };
                // pokemons.Append<Pokemon>(a);
                pokemons.Add(a);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
