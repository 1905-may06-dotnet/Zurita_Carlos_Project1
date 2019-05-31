using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        Models.Topping t;
        List<Models.Topping> ToppingList = new List<Models.Topping>();
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
        // GET: Order
        public ActionResult OrdersPage(int uoid)
        {
            var orders = db.GetOrders();
            ViewBag.UOID = uoid;
            ViewBag.UOIDName = db.GetUserByUserid(uoid).Username;
            ViewBag.UOIDLoc = db.GetUserByUserid(uoid).Ulocationid;
            foreach (var order in orders)
            {
                o = new Models.Order();
                o.Orderid = order.Orderid;
                o.Ocustomerid = order.Ocustomerid;
                o.Datetime = order.Datetime;
                o.Numo++;
                OrderList.Add(o);
                ViewData["Username"] = db.GetUserByUserid(order.Ocustomerid).Username;
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
            dmu.Ulocationid = user.Ulocationid;
            try
            {
                // TODO: Add insert logic here
                db.AddUser(dmu);
                db.Save();
                return RedirectToAction(nameof(UsersPage), new { lid = user.Ulocationid });
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
        public ActionResult CreateOrder(int uid)
        {
            ViewBag.UID = uid;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrder(IFormCollection collection, Models.Order order)
        {
            PizzaBox.Domain.Order dmo = new Order();
            dmo.Orderid = order.Orderid;
            dmo.Ocustomerid = order.Ocustomerid;
            dmo.Datetime = order.Datetime;
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