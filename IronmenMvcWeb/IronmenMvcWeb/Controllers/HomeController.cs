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
        public List<Pokemon> _pokemons;
        public List<Pokemon> pokemons
        {
            get {
                if (this._pokemons == null)
                    this._pokemons = new List<Pokemon>();
                return this._pokemons;
            }
        }

        public List<Report> _reports;
        public List<Report> reports
        {
            get
            {
                if (this._reports == null)
                    this._reports = new List<Report>();
                return this._reports;
            }
        }

        public List<Member> _members;
        public List<Member> members {
            get
            {
                if (this._members == null)
                    this._members = new List<Member>();
                return this._members;
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
            /*
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
            */

            var rep1 = new Report()
            {
                Title = "Bounded biharmonic weights for real-time deformation",
                Author = "Alec Jacobson,Ilya Baran,Jovan Popović,Olga ",
                PublishDate = "2014",
                Source = "ACM CACM",
                Date = "4/11",
            };
            reports.Add(rep1);

            var rep2 = new Report()
            {
                Title = "Learning to Group Discrete Graphical Patterns",
                Author = "Zhaoliang Lun*, Changqing Zou*, Haibin Huang, Evangelos Kalogerakis, Ping Tan, Marie-Paule Cani, Hao Zhang",
                PublishDate = "November 2017",
                Source = "ACM Transactions on Graphics (TOG)",
                Date = "3/29",
            };
            reports.Add(rep2);


            // return View(pokemon);
            // return View(pokemons);
            return View(reports);
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

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            /*   string Username = post["username"];
               string password1 = post["password1"];
               string password2 = post["password2"];

               if (string.IsNullOrWhiteSpace(password1) || password1 != password2)
               {
                   ViewBag.Msg = "密碼輸入錯誤";
                   return View();
               }
               else
               {
                   Response.Redirect("Login");
                   return new EmptyResult();
               }*/
            if (ModelState.IsValid)
            {
                var member = new Member()
                {
                    Username = "江宇軒",
                    StudentID = "107598000",
                    Email = "fuck@gmail.com",
                    Password = "123456",
                };
                // pokemons.Append<Pokemon>(a);
                members.Add(member);
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
