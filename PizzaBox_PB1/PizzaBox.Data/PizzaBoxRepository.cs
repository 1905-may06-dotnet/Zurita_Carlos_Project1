using PizzaBox.Data.Entities;
using PizzaBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Data
{
    public class PizzaBoxRepository : IPizzaBoxRepository
    {
        private readonly PizzaContext _db;
        public PizzaBoxRepository(PizzaContext db)
        {
            _db = db;
        }

        public void AddLocation(Domain.Location location)
        {
            _db.Location.Add(Mapper.Map(location));
        }
        public void DeleteLocation(int locationid)
        {
            _db.Location.Remove(_db.Location.Find(locationid));
        }
        public void EditLocation(Domain.Location location)
        {
            if (_db.Location.Find(location.Locationid) != null)
                _db.Location.Update(Mapper.Map(location));
        }
        public Domain.Location GetLocationByCity(string city)
        {
            //throw new NotImplementedException();
            var element = _db.Location.Where(a => a.City.Contains(city)).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public Domain.Location GetLocationByLocationid(int locationid)
        {
            //throw new NotImplementedException();
            var element = _db.Location.Where(a => a.Locationid == locationid).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public IEnumerable<Domain.Location> GetLocations()
        {
            return _db.Location.Select(x => Mapper.Map(x));
        }

        public void AddUser(Domain.User user)
        {
            _db.User.Add(Mapper.Map(user));
        }
        public void DeleteUser(int userid)
        {
            _db.User.Remove(_db.User.Find(userid));
        }
        public void EditUser(Domain.User user)
        {
            if (_db.User.Find(user.Userid) != null)
                _db.User.Update(Mapper.Map(user));
        }
        public Domain.User GetUserByUsername(string username)
        {
            //throw new NotImplementedException();
            var element = _db.User.Where(a => a.Username.Contains(username)).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public Domain.User GetUserByUserid(int userid)
        {
            //throw new NotImplementedException();
            var element = _db.User.Where(a => a.Userid == userid).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public IEnumerable<Domain.User> GetUsers()
        {
            return _db.User.Select(x => Mapper.Map(x));
        }

        public void AddOrder(Domain.Order order)
        {
            _db.Order.Add(Mapper.Map(order));
        }
        public void DeleteOrder(int orderid)
        {
            _db.Order.Remove(_db.Order.Find(orderid));
        }
        public void EditOrder(Domain.Order order)
        {
            if (_db.Order.Find(order.Orderid) != null)
                _db.Order.Update(Mapper.Map(order));
        }
        public Domain.Order GetOrderByOcustomerid(int ocustomerid)
        {
            //throw new NotImplementedException();
            var element = _db.Order.Where(a => a.Ocustomerid == ocustomerid).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public Domain.Order GetOrderByOrderid(int orderid)
        {
            //throw new NotImplementedException();
            var element = _db.Order.Where(a => a.Orderid == orderid).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public IEnumerable<Domain.Order> GetOrders()
        {
            return _db.Order.Select(x => Mapper.Map(x));
        }

        public void AddPizza(Domain.Pizza pizza)
        {
            _db.Pizza.Add(Mapper.Map(pizza));
        }
        public void DeletePizza(int pizzaid)
        {
            _db.Pizza.Remove(_db.Pizza.Find(pizzaid));
        }
        public void EditPizza(Domain.Pizza pizza)
        {
            if (_db.Pizza.Find(pizza.Pizzaid) != null)
                _db.Pizza.Update(Mapper.Map(pizza));
        }
        public Domain.Pizza GetPizzaByPorderid(int porderid)
        {
            //throw new NotImplementedException();
            var element = _db.Pizza.Where(a => a.Porderid == porderid).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public Domain.Pizza GetPizzaByPizzaid(int pizzaid)
        {
            //throw new NotImplementedException();
            var element = _db.Pizza.Where(a => a.Pizzaid == pizzaid).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public IEnumerable<Domain.Pizza> GetPizzas()
        {
            return _db.Pizza.Select(x => Mapper.Map(x));
        }

        public void AddTopping(Domain.Topping topping)
        {
            _db.Topping.Add(Mapper.Map(topping));
        }
        public void DeleteTopping(int toppingid)
        {
            _db.Topping.Remove(_db.Topping.Find(toppingid));
        }
        public void EditTopping(Domain.Topping topping)
        {
            if (_db.Topping.Find(topping.Toppingid) != null)
                _db.Topping.Update(Mapper.Map(topping));
        }
        public Domain.Topping GetToppingByTpizzaid(int tpizzaid)
        {
            //throw new NotImplementedException();
            var element = _db.Topping.Where(a => a.Tpizzaid == tpizzaid).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public Domain.Topping GetToppingByToppingid(int toppingid)
        {
            //throw new NotImplementedException();
            var element = _db.Topping.Where(a => a.Toppingid == toppingid).FirstOrDefault();
            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }
        public IEnumerable<Domain.Topping> GetToppings()
        {
            return _db.Topping.Select(x => Mapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        
    }
}
