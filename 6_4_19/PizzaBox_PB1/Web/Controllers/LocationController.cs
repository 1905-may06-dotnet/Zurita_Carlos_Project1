﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Dynamic;

namespace Web.Controllers
{
    public class LocationController : Controller
    {
        private readonly IPizzaBoxRepository db;
        public LocationController(IPizzaBoxRepository db)
        {
            this.db = db;
        }
        public static int universaluserid;
        Models.Location l;
        List<Models.Location> LocationList = new List<Models.Location>();
        Models.User u;
        List<Models.User> UserList = new List<Models.User>();
        Models.Order o;
        List<Models.Order> OrderList = new List<Models.Order>();
        Models.Pizza p;
        List<Models.Pizza> PizzaList = new List<Models.Pizza>();
        Models.Pizza pi;
        List<Models.Pizza> PreviewList = new List<Models.Pizza>();
        Models.Topping t;
        List<Models.Topping> ToppingList = new List<Models.Topping>();
        Models.User use;
        List<Models.User> UserRegList = new List<Models.User>();
        // GET: Location
        public ActionResult Index()
        {
            var locations = db.GetLocations();
            foreach (var location in locations)
            {
                l = new Models.Location();
                l.Locationid = location.Locationid;
                l.Street1 = location.Street1;
                l.Street2 = location.Street2;
                l.Num++;
                l.City = location.City;
                l.State = location.State;
                l.Country = location.Country;
                l.Zipcode = location.Zipcode;
                LocationList.Add(l);
            }
            return View(LocationList);
        }
        public ActionResult LocationsPage(int lpid)
        {
            var nlocations = db.GetLocations();
            ViewBag.LPID = lpid;
            foreach (var nlocation in nlocations)
            {
                l = new Models.Location();
                l.Locationid = nlocation.Locationid;
                l.Street1 = nlocation.Street1;
                l.Street2 = nlocation.Street2;
                l.Num++;
                l.City = nlocation.City;
                l.State = nlocation.State;
                l.Country = nlocation.Country;
                l.Zipcode = nlocation.Zipcode;
                LocationList.Add(l);
            }
            return View(LocationList);
        }
        public ActionResult UserSignedIn(int lsid)
        {
            var userssignedin = db.GetUsers();
            ViewBag.LSID = lsid;
            ViewBag.LSIDName = db.GetUserByUserid(lsid).Username;
            ViewBag.LSIDLoc = db.GetLocationByLocationid(lsid).City;
            foreach (var usersignedin in userssignedin)
            {
                u = new Models.User();
                u.Userid = usersignedin.Userid;
                u.Username = usersignedin.Username;
                u.Password = usersignedin.Password;
                u.Numu++;
                u.Firstname = usersignedin.Firstname;
                u.Lastname = usersignedin.Lastname;
                u.Ulocationid = usersignedin.Ulocationid;
                UserList.Add(u);
                //ViewData["Location"] = db.GetLocationByLocationid(usersignedin.Ulocationid).City;
            }
            return View(UserList);
        }
        public ActionResult AdminsPage()
        {
            var apizzas = db.GetPizzas();
            var atops = db.GetToppings();
            //ViewBag.OPID = opid;
            ViewBag.ADIDUser = 1;
            ViewBag.ADIDName = db.GetUserByUserid(1).Username;
            int totalnumofpad = 0;
            int totalnumoftad = 0;
            int totalordercostad = 0;
            foreach (var pizza in apizzas)
            {
                p = new Models.Pizza();
                p.Pizzaid = pizza.Pizzaid;
                p.Size = pizza.Size;
                p.Crust = pizza.Crust;
                //p.Cost = pizza.Cost;
                int toppingcount = 1;
                foreach (var atop in atops)
                {
                    //totalnumoftad += 1;
                    if (atop.Tpizzaid == pizza.Pizzaid)
                    {
                        pizza.Cost += 2;
                        if (toppingcount == 1)
                        {
                            p.ToppingN1 = atop.Topping1;
                        }
                        if (toppingcount == 2)
                        {
                            p.ToppingN2 = atop.Topping1;
                        }
                        if (toppingcount == 3)
                        {
                            p.ToppingN3 = atop.Topping1;
                        }
                        if (toppingcount == 4)
                        {
                            p.ToppingN4 = atop.Topping1;
                        }
                        if (toppingcount == 5)
                        {
                            p.ToppingN5 = atop.Topping1;
                        }
                        toppingcount += 1;
                    }

                }
                p.Cost = pizza.Cost;
                totalordercostad += p.Cost;
                p.Porderid = pizza.Porderid;
                p.Nump++;
                PizzaList.Add(p);
                ViewData["Customer"] = db.GetUserByUserid(1).Username;
                totalnumofpad += 1;
            }
            foreach (var atop in atops)
            {
                totalnumoftad += 1;
            }
            ViewBag.toca = totalordercostad;
            ViewBag.tnop = totalnumofpad;
            ViewBag.tnot = totalnumoftad;
            ViewBag.inventoryleft = 500 - totalnumofpad;
            int costofprod = totalnumofpad * 5;
            ViewBag.profit = totalordercostad - costofprod;
            return View(PizzaList);
        }
        // GET: User
        public ActionResult UsersPage(int lid)
        {
            var users = db.GetUsers();
            ViewBag.LID = lid;
            ViewBag.LIDName = db.GetLocationByLocationid(lid).City;
            foreach (var user in users)
            {
                u = new Models.User();
                u.Userid = user.Userid;
                u.Username = user.Username;
                u.Password = user.Password;
                u.Numu++;
                u.Firstname = user.Firstname;
                u.Lastname = user.Lastname;
                u.Ulocationid = user.Ulocationid;
                UserList.Add(u);
                //ViewBag.UOIDLocation = db.GetLocationByLocationid(user.Ulocationid).City;
            }
            return View(UserList);
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult IsAlreadyRegistered(string Username)
        {
            return Json(IsUserAvailable(Username));
            //return Json(IsUserAvailable(UserNameEntered));
        }
        public bool IsUserAvailable(string UserNameCheck)
        {
            var RegisteredUsers = db.GetUsers();
            foreach (var RegisteredUser in RegisteredUsers)
            {
                use = new Models.User();
                use.Userid = RegisteredUser.Userid;
                use.Username = RegisteredUser.Username;
                use.Password = RegisteredUser.Password;
                use.Numu++;
                use.Firstname = RegisteredUser.Firstname;
                use.Lastname = RegisteredUser.Lastname;
                use.Ulocationid = RegisteredUser.Ulocationid;
                UserRegList.Add(use);
            }
            var RegUsername = (from u in UserRegList
                              where u.Username.ToUpper() == UserNameCheck.ToUpper()
                              select new { UserNameCheck }).FirstOrDefault();

            bool status;
            if (RegUsername != null)
            {
                //Already registered  
                status = false;
            }
            else
            {
                //Available to use  
                status = true;
            }
            return status;
        }
        // GET: Order
        public ActionResult OrdersPage(int uoid)
        {
            var orders = db.GetOrders();
            var pizzasinorder = db.GetPizzas();
            ViewBag.UOID = uoid;
            ViewBag.UOIDName = db.GetUserByUserid(uoid).Username;
            ViewBag.UOIDLoc = db.GetUserByUserid(uoid).Ulocationid;
            DateTime localDate = DateTime.Now;
            foreach (var order in orders)
            {
                o = new Models.Order();
                o.Orderid = order.Orderid;
                o.Ocustomerid = order.Ocustomerid;
                o.Datetime = order.Datetime;
                o.Numo++;
                OrderList.Add(o);
                ViewData["Username"] = db.GetUserByUserid(order.Ocustomerid).Username;
                o.totalordercostp = 0;
                foreach (var pizzainorder in pizzasinorder)
                {
                    if (pizzainorder.Porderid == o.Orderid)
                    {
                        o.totalordercostp += pizzainorder.Cost;
                    }
                }
            }
            return View(OrderList);
        }
        
        public ActionResult PizzasPage(int opid)
        {
            var pizzas = db.GetPizzas();
            ViewBag.OPID = opid;
            ViewBag.PTIDUser = db.GetOrderByOrderid(opid).Ocustomerid;
            ViewBag.PTIDName = db.GetUserByUserid(db.GetOrderByOrderid(opid).Ocustomerid).Username;
            foreach (var pizza in pizzas)
            {
                p = new Models.Pizza();
                p.Pizzaid = pizza.Pizzaid;
                p.Size = pizza.Size;
                p.Crust = pizza.Crust;
                p.Cost = pizza.Cost;
                p.Porderid = pizza.Porderid;
                p.Nump++;
                PizzaList.Add(p);
                ViewData["Customer"] = db.GetUserByUserid(db.GetOrderByOrderid(pizza.Porderid).Ocustomerid).Username;
            }
            return View(PizzaList);
        }

        public ActionResult ToppingsPage(int ptid)
        {
            var toppings = db.GetToppings();
            ViewBag.PTID = ptid;
            ViewBag.PTIDOrder = db.GetPizzaByPizzaid(ptid).Porderid;
            foreach (var topping in toppings)
            {
                t = new Models.Topping();
                t.Toppingid = topping.Toppingid;
                t.Tpizzaid = topping.Tpizzaid;
                t.Topping1 = topping.Topping1;
                t.Numt++;
                ToppingList.Add(t);
            }
            return View(ToppingList);
        }

        public ActionResult OrdersPreview(int uoid)
        {
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            //mymodel.Orders = db.GetOrders();
            //mymodel.Pizzas = db.GetPizzas();
            //mymodel.Toppings = db.GetToppings();
            var orderps = db.GetOrders();
            var pizzaps = db.GetPizzas();
            var toppingps = db.GetToppings();
            foreach (var toppingp in toppingps)
            {
                t = new Models.Topping();
                t.Toppingid = toppingp.Toppingid;
                t.Tpizzaid = toppingp.Tpizzaid;
                t.Topping1 = toppingp.Topping1;
                t.Numt++;
                ToppingList.Add(t);
            }
            foreach (var pizzap in pizzaps)
            {
                p = new Models.Pizza();
                p.Pizzaid = pizzap.Pizzaid;
                p.Size = pizzap.Size;
                p.Crust = pizzap.Crust;
                p.Cost = pizzap.Cost;
                p.Porderid = pizzap.Porderid;
                p.Nump++;
                PizzaList.Add(p);
            }
            foreach (var orderp in orderps)
            {
                o = new Models.Order();
                o.Orderid = orderp.Orderid;
                o.Ocustomerid = orderp.Ocustomerid;
                o.Datetime = orderp.Datetime;
                o.Numo++;
                OrderList.Add(o);
                
            }
            mymodel.Toppings = ToppingList;
            mymodel.Pizzas = PizzaList;
            mymodel.Orders = OrderList;
            return View(mymodel);
        }

        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Location/Create
        [HttpGet]
        public ActionResult Create(int luid)
        {
            ViewBag.LUID = luid;
            TempData["Locationid"] = db.GetUserByUserid(luid).Ulocationid;
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.User user)
        {
            PizzaBox.Domain.User dmu = new User();
            dmu.Userid = user.Userid;
            dmu.Username = user.Username;
            dmu.Password = user.Password;
            dmu.Firstname = user.Firstname;
            dmu.Lastname = user.Lastname;
            //dmu.Ulocationid = user.Ulocationid;
            dmu.Ulocationid = (int)TempData["Locationid"];
            try
            {
                // TODO: Add insert logic here
                db.AddUser(dmu);
                db.Save();
                return RedirectToAction(nameof(UsersPage), new { lid = dmu.Ulocationid });
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult CreateSignIn(int signinid)
        {
            //universaluserid = signinid;
            PizzaBox.Domain.BusinessLogic.GlobalId = signinid;
            ViewBag.SIGNINID = signinid;
            ViewBag.SIGNINIDName = db.GetUserByUserid(signinid).Username;
            ViewBag.SIGNINIDPass = db.GetUserByUserid(signinid).Password;
            ViewBag.SIGNINIDFName = db.GetUserByUserid(signinid).Firstname;
            ViewBag.SIGNINIDLName = db.GetUserByUserid(signinid).Lastname;
            ViewBag.SIGNINIDLoc = db.GetUserByUserid(signinid).Ulocationid;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSignIn(IFormCollection collection, Models.User siuser)
        {
            PizzaBox.Domain.User siu = new User();
            //siu.Userid = siuser.Userid;
            siu.Username = siuser.Username;
            siu.Password = siuser.Password;
            try
            {
                if (siu.Password == db.GetUserByUserid(PizzaBox.Domain.BusinessLogic.GlobalId).Password)
                {
                    //return RedirectToAction(nameof(UsersPage), new { lid = siuser.Ulocationid });
                    //return RedirectToAction(nameof(UsersPage), new { lid = db.GetUserByUsername(siu.Username).Ulocationid });
                    return RedirectToAction(nameof(UserSignedIn), new { lsid = PizzaBox.Domain.BusinessLogic.GlobalId });
                }
                else
                {
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUserid(ViewBag.SIGNINID).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUserid(universaluserid).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUsername(db.GetUserByUserid(universaluserid).Username).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUserid(db.GetUserByUsername(siu.Username).Userid).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUserid(PizzaBox.Domain.BusinessLogic.GlobalId).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = PizzaBox.Domain.BusinessLogic.GlobalId });
                    //return RedirectToAction(nameof(UsersPage), new { lid = siuser.Ulocationid });
                    //return RedirectToAction(nameof(UsersPage), new { lid = db.GetUserByUsername(siu.Username).Userid });
                    //return RedirectToAction(nameof(CreateSignIn), db.GetUserByUsername(siu.Username).Userid);
                    return RedirectToAction(nameof(CreateSignIn), new { signinid = db.GetUserByUsername(siu.Username).Userid });
                }
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult CreateAnySignIn()
        {
            //universaluserid = signinid;
            //PizzaBox.Domain.BusinessLogic.GlobalId = signinid;
            //ViewBag.SIGNINID = signinid;
            //ViewBag.SIGNINIDName = db.GetUserByUserid(signinid).Username;
            //ViewBag.SIGNINIDPass = db.GetUserByUserid(signinid).Password;
            //ViewBag.SIGNINIDFName = db.GetUserByUserid(signinid).Firstname;
            //ViewBag.SIGNINIDLName = db.GetUserByUserid(signinid).Lastname;
            //ViewBag.SIGNINIDLoc = db.GetUserByUserid(signinid).Ulocationid;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAnySignIn(IFormCollection collection, Models.User siuser)
        {
            PizzaBox.Domain.User siu = new User();
            //siu.Userid = siuser.Userid;
            //siu.Username = siuser.Username;
            siu.Username = siuser.Usernamein;
            siu.Password = siuser.Password;
            PizzaBox.Domain.BusinessLogic.GlobalId = db.GetUserByUsername(siuser.Usernamein).Userid;
            try
            {
                if (siu.Password == db.GetUserByUserid(PizzaBox.Domain.BusinessLogic.GlobalId).Password)
                {
                    if (siuser.Usernamein == "carlosz")
                    {
                        //return RedirectToAction(nameof(OrdersPage), new { uoid = PizzaBox.Domain.BusinessLogic.GlobalId });
                        return RedirectToAction(nameof(AdminsPage));
                    }
                    else
                    {
                        return RedirectToAction(nameof(UserSignedIn), new { lsid = PizzaBox.Domain.BusinessLogic.GlobalId });
                    }
                    //return RedirectToAction(nameof(Index), "Home", new { lsid = PizzaBox.Domain.BusinessLogic.GlobalId });
                }
                else
                {
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUserid(ViewBag.SIGNINID).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUserid(universaluserid).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUsername(db.GetUserByUserid(universaluserid).Username).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUserid(db.GetUserByUsername(siu.Username).Userid).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = db.GetUserByUserid(PizzaBox.Domain.BusinessLogic.GlobalId).Ulocationid });
                    //return RedirectToAction(nameof(UserSignedIn), new { lsid = PizzaBox.Domain.BusinessLogic.GlobalId });
                    //return RedirectToAction(nameof(UsersPage), new { lid = siuser.Ulocationid });
                    //return RedirectToAction(nameof(UsersPage), new { lid = db.GetUserByUsername(siu.Username).Userid });
                    //return RedirectToAction(nameof(CreateSignIn), db.GetUserByUsername(siu.Username).Userid);
                    return RedirectToAction(nameof(CreateAnySignIn));
                }
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult CreateAny()
        {
            
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAny(IFormCollection collection, Models.User user)
        {
            PizzaBox.Domain.User dmu = new User();
            dmu.Userid = user.Userid;
            dmu.Username = user.Username;
            dmu.Password = user.Password;
            dmu.Firstname = user.Firstname;
            dmu.Lastname = user.Lastname;
            dmu.Ulocationid = user.Ulocationid;
            try
            {
                //return RedirectToAction(nameof(UsersPage), new { lid = 1 });
                db.AddUser(dmu);
                db.Save();
                //return RedirectToAction(nameof(UsersPage), new { lid = dmu.Ulocationid });
                return RedirectToAction(nameof(UserSignedIn), new { lsid = dmu.Userid });
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult CreateOrder(int uid)
        {
            DateTime currenttime = DateTime.Now;
            var currentuser = db.GetUserByUserid(uid);
            var allusers = db.GetUsers();
            var allorders = db.GetOrders();
            int orderlength = 0;
            int allorderslength = 0;
            int innerolength = 0;
            int usermaxl = 0;
            int usercounter = 0;
            foreach (var allorder in allorders)
            {
                if (allorder.Ocustomerid == uid)
                {
                    orderlength += 1;
                }
            }
            int ocounterl = orderlength;
            foreach (var allorder in allorders)
            {
                allorderslength += 1;
                if (allorder.Ocustomerid == uid)
                {
                    innerolength += 1;
                    if (innerolength == ocounterl)
                    {
                        usercounter = allorderslength;
                        break;
                    }
                }
            }

            ViewBag.usercounter = usercounter;
            ViewBag.allorderslength = allorderslength;
            ViewBag.orderlength = orderlength;
            var maxorder = db.GetOrderByOrderid(usercounter);
            var orderdt = maxorder.Datetime;
            ViewBag.orderdt = orderdt;
            DateTime dt;
            //if (orderdt.HasValue)
            dt = orderdt.Value;
            DateTime dt2 = dt.AddHours(2);
            //DateTime dt2 = dt.AddMinutes(50);
            ViewBag.orderallow = DateTime.Compare(currenttime, dt2);
            //ViewBag.orderallow;
            //DateTime nextday = DateTime.Now.AddHours(24);
            //int orderallow = DateTime.Compare(currenttime, nextday);
            ViewBag.UID = uid;
            //ViewBag.orderallow = orderallow;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrder(IFormCollection collection, Models.Order order)
        {
            PizzaBox.Domain.Order dmo = new Order();
            dmo.Orderid = order.Orderid;
            dmo.Ocustomerid = order.Ocustomerid;
            //dmo.Datetime = order.Datetime;
            dmo.Datetime = DateTime.Now;
            try
            {
                db.AddOrder(dmo);
                db.Save();
                return RedirectToAction(nameof(OrdersPage), new { uoid = db.GetUserByUserid(dmo.Ocustomerid).Userid });
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult CreatePizza(int id)
        {
            ViewBag.ID = id;
            ViewBag.IDUserid = db.GetOrderByOrderid(id).Ocustomerid;
            int numberofpizzas = 0;
            var pizzasinorder = db.GetPizzas();
            foreach (var pizzainorder in pizzasinorder)
            {
                if (pizzainorder.Porderid == id)
                {
                    numberofpizzas++;
                }
            }
            //if (numberofpizzas >= 100)
            if (numberofpizzas >= 2)
            {
                ViewBag.LIMIT = 1;
            }
            else
            {
                ViewBag.LIMIT = 0;
            }
            ViewBag.NumOfP = numberofpizzas;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePizza(IFormCollection collection, Models.Pizza pizza)
        {
            PizzaBox.Domain.Pizza dmp = new Pizza();
            dmp.Pizzaid = pizza.Pizzaid;
            dmp.Size = pizza.Size;
            int SizeCost = PizzaBox.Domain.BusinessLogic.SizeCost(pizza.Size);
            dmp.Crust = pizza.Crust;
            int CrustCost = PizzaBox.Domain.BusinessLogic.CrustCost(pizza.Crust);
            //dmp.Cost = pizza.Cost;
            dmp.Cost = PizzaBox.Domain.BusinessLogic.totalordercost(SizeCost,CrustCost);
            dmp.Porderid = pizza.Porderid;
            try
            {
                db.AddPizza(dmp);
                db.Save();
                return RedirectToAction(nameof(CreatePizza), new { id = dmp.Porderid });
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult CreatePizzaPrev(int upreid)
        {
            //ViewBag.ID = id;
            var alloftheordersplus1 = db.GetOrders();
            int nextorderofbus1 = 0;
            foreach (var alloftheorderplus1 in alloftheordersplus1)
            {
                nextorderofbus1 += 1;
            }
            nextorderofbus1 += 1;
            ViewBag.ID = nextorderofbus1;
            //ViewBag.ID = opreid;
            //ViewBag.IDUserid = db.GetOrderByOrderid(opreid).Ocustomerid;
            ViewBag.IDUserid = upreid;
            TempData["prevuid1"] = upreid;
            //TempData["OrderID11"] = opreid;
            int numberofpizzas = 0;
            var pizzasinorder = db.GetPizzas();
            foreach (var pizzainorder in pizzasinorder)
            {
                if (pizzainorder.Porderid == nextorderofbus1)
                {
                    numberofpizzas++;
                }
            }
            if (numberofpizzas >= 100)
            {
                ViewBag.LIMIT = 1;
            }
            else
            {
                ViewBag.LIMIT = 0;
            }
            ViewBag.NumOfP = numberofpizzas;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePizzaPrev(IFormCollection collection, Models.Pizza pizza)
        {
            PizzaBox.Domain.Pizza dmp = new Pizza();
            dmp.Pizzaid = pizza.Pizzaid;
            dmp.Size = pizza.Size;
            int SizeCost = PizzaBox.Domain.BusinessLogic.SizeCost(pizza.Size);
            dmp.Crust = pizza.Crust;
            int CrustCost = PizzaBox.Domain.BusinessLogic.CrustCost(pizza.Crust);
            //dmp.Cost = pizza.Cost;
            dmp.Cost = PizzaBox.Domain.BusinessLogic.totalordercost(SizeCost, CrustCost);
            var alloftheordersplus = db.GetOrders();
            int nextorderofbus = 0;
            foreach (var alloftheorderplus in alloftheordersplus)
            {
                nextorderofbus += 1;
            }
            nextorderofbus += 1;
            dmp.Porderid = nextorderofbus;
            //dmp.Porderid = (int)TempData["OrderID11"];
            var allofthepizzas = db.GetPizzas();
            int totalnumofpall = 0;
            foreach (var allofthepizza in allofthepizzas)
            {
                totalnumofpall += 1;
            }
            totalnumofpall += 1;
            try
            {
                //db.AddPizza(dmp);
                //db.Save();
                TempData["ID"] = totalnumofpall;
                TempData["Size"] = dmp.Size;
                TempData["Crust"] = dmp.Crust;
                TempData["Cost"] = dmp.Cost;
                //TempData["Porderid"] = dmp.Porderid;
                TempData["Porderid"] = nextorderofbus;
                return RedirectToAction(nameof(PizzasPagePrev), new { prevuid = (int)TempData["prevuid1"] });
            }
            catch
            {
                return View();
            }
        }
        public ActionResult PizzasPagePrev(int prevuid)
        {
            //var pizzas = db.GetPizzas();
            int PID1 = (int)TempData["ID"];
            string SIZE1 = (string)TempData["Size"];
            string CRUST1 = (string)TempData["Crust"];
            int COST1 = (int)TempData["Cost"];
            int POID1 = (int)TempData["Porderid"];
            p = new Models.Pizza();
            p.Pizzaid = PID1;
            p.Size = SIZE1;
            p.Crust = CRUST1;
            p.Cost = COST1;
            p.Porderid = POID1;
            TempData["ID2"] = PID1;
            TempData["Size2"] = SIZE1;
            TempData["Crust2"] = CRUST1;
            TempData["Cost2"] = COST1;
            TempData["Porderid2"] = POID1;
            //p.Nump++;
            PizzaList.Add(p);
            ViewBag.prevuid2 = prevuid;
            return View(PizzaList);
        }
        [HttpGet]
        public ActionResult CreateOrderPrev(int uid)
        {
            DateTime currenttime = DateTime.Now;
            var currentuser = db.GetUserByUserid(uid);
            var allusers = db.GetUsers();
            var allorders = db.GetOrders();
            int orderlength = 0;
            int allorderslength = 0;
            int innerolength = 0;
            int usermaxl = 0;
            int usercounter = 0;
            foreach (var allorder in allorders)
            {
                if (allorder.Ocustomerid == uid)
                {
                    orderlength += 1;
                }
            }
            int ocounterl = orderlength;
            foreach (var allorder in allorders)
            {
                allorderslength += 1;
                if (allorder.Ocustomerid == uid)
                {
                    innerolength += 1;
                    if (innerolength == ocounterl)
                    {
                        usercounter = allorderslength;
                        break;
                    }
                }
            }

            ViewBag.usercounter = usercounter;
            ViewBag.allorderslength = allorderslength;
            ViewBag.orderlength = orderlength;
            var maxorder = db.GetOrderByOrderid(usercounter);
            //var orderdt = maxorder.Datetime;
            //ViewBag.orderdt = orderdt;
            //DateTime dt;
            
            //dt = orderdt.Value;
            //DateTime dt2 = dt.AddHours(2);
            
            //ViewBag.orderallow = DateTime.Compare(currenttime, dt2);
            
            ViewBag.UID = uid;
            ViewBag.orderallow = 1;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrderPrev(IFormCollection collection, Models.Order order)
        {
            PizzaBox.Domain.Order dmo = new Order();
            dmo.Orderid = order.Orderid;
            dmo.Ocustomerid = order.Ocustomerid;
            //dmo.Datetime = order.Datetime;
            dmo.Datetime = DateTime.Now;
            try
            {
                db.AddOrder(dmo);
                db.Save();
                return RedirectToAction(nameof(CreatePizzaPreview));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult CreatePizzaPreview()
        {
            int PID2 = (int)TempData["ID2"];
            string SIZE2 = (string)TempData["Size2"];
            string CRUST2 = (string)TempData["Crust2"];
            int COST2 = (int)TempData["Cost2"];
            int POID2 = (int)TempData["Porderid2"];

            ViewBag.PID2 = PID2;
            ViewBag.SIZE2 = SIZE2;
            ViewBag.CRUST2 = CRUST2;
            ViewBag.COST2 = COST2;
            ViewBag.POID2 = POID2;

            TempData["ID3"] = PID2;
            TempData["Size3"] = SIZE2;
            TempData["Crust3"] = CRUST2;
            TempData["Cost3"] = COST2;
            TempData["Porderid3"] = POID2;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePizzaPreview(IFormCollection collection, Models.Pizza pizza)
        {
            PizzaBox.Domain.Pizza dmp3 = new Pizza();
            dmp3.Pizzaid = (int)TempData["ID3"];
            dmp3.Size = (string)TempData["Size3"];
            dmp3.Crust = (string)TempData["Crust3"];
            dmp3.Cost = (int)TempData["Cost3"];
            dmp3.Porderid = (int)TempData["Porderid3"];
            try
            {
                db.AddPizza(dmp3);
                db.Save();
                return RedirectToAction(nameof(PizzasPage), new { opid = dmp3.Porderid });
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult CreatedefonePizza(int id)
        {
            ViewBag.ID = id;
            TempData["PassID"] = id;
            ViewBag.IDUserid = db.GetOrderByOrderid(id).Ocustomerid;
            int numberofpizzas = 0;
            var pizzasinorder = db.GetPizzas();
            foreach (var pizzainorder in pizzasinorder)
            {
                if (pizzainorder.Porderid == id)
                {
                    numberofpizzas++;
                }
            }
            if (numberofpizzas >= 100)
            {
                ViewBag.LIMIT = 1;
            }
            else
            {
                ViewBag.LIMIT = 0;
            }
            ViewBag.NumOfP = numberofpizzas;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatedefonePizza(IFormCollection collection, Models.Pizza pizza)
        {
            PizzaBox.Domain.Pizza dmp = new Pizza();
            dmp.Pizzaid = pizza.Pizzaid;
            dmp.Size = "Small";
            int SizeCost = PizzaBox.Domain.BusinessLogic.SizeCost(dmp.Size);
            dmp.Crust = "Thick";
            int CrustCost = PizzaBox.Domain.BusinessLogic.CrustCost(dmp.Crust);
            //dmp.Cost = pizza.Cost;
            dmp.Cost = PizzaBox.Domain.BusinessLogic.totalordercost(SizeCost, CrustCost);
            dmp.Porderid = pizza.Porderid;
            dmp.Porderid = (int)TempData["PassID"];
            try
            {
                db.AddPizza(dmp);
                db.Save();
                return RedirectToAction(nameof(CreatedefonePizza), new { id = dmp.Porderid });
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult CreatedeftwoPizza(int id)
        {
            ViewBag.ID = id;
            TempData["PassID2"] = id;
            ViewBag.IDUserid = db.GetOrderByOrderid(id).Ocustomerid;
            int numberofpizzas = 0;
            var pizzasinorder = db.GetPizzas();
            foreach (var pizzainorder in pizzasinorder)
            {
                if (pizzainorder.Porderid == id)
                {
                    numberofpizzas++;
                }
            }
            if (numberofpizzas >= 100)
            {
                ViewBag.LIMIT = 1;
            }
            else
            {
                ViewBag.LIMIT = 0;
            }
            ViewBag.NumOfP = numberofpizzas;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatedeftwoPizza(IFormCollection collection, Models.Pizza pizza)
        {
            PizzaBox.Domain.Pizza dmp = new Pizza();
            dmp.Pizzaid = pizza.Pizzaid;
            dmp.Size = "Medium";
            int SizeCost = PizzaBox.Domain.BusinessLogic.SizeCost(dmp.Size);
            dmp.Crust = "Flat";
            int CrustCost = PizzaBox.Domain.BusinessLogic.CrustCost(dmp.Crust);
            //dmp.Cost = pizza.Cost;
            dmp.Cost = PizzaBox.Domain.BusinessLogic.totalordercost(SizeCost, CrustCost);
            dmp.Porderid = (int)TempData["PassID2"];
            try
            {
                db.AddPizza(dmp);
                db.Save();
                return RedirectToAction(nameof(CreatedeftwoPizza), new { id = dmp.Porderid });
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult CreateTopping(int pid)
        {
            ViewBag.PID = pid;
            ViewBag.PIDUser = db.GetOrderByOrderid(db.GetPizzaByPizzaid(pid).Porderid).Ocustomerid;
            ViewBag.PIDOrder = db.GetPizzaByPizzaid(pid).Porderid;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTopping(IFormCollection collection, Models.Topping topping)
        {
            PizzaBox.Domain.Topping dmt = new Topping();
            dmt.Toppingid = topping.Toppingid;
            dmt.Tpizzaid = topping.Tpizzaid;
            dmt.Topping1 = topping.Topping1;
            try
            {
                db.AddTopping(dmt);
                db.Save();
                return RedirectToAction(nameof(CreateTopping), new { pid = topping.Tpizzaid });
                //return RedirectToAction(nameof(ToppingsPage));
            }
            catch
            {
                return View();
            }
        }
        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Location/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Location/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}