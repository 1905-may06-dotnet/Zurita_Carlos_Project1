using System;
using System.Collections.Generic;



namespace PizzaBox.Domain
{
    public interface IPizzaBoxRepository
    {
        void AddLocation(Location location);
        void EditLocation(Location location);
        void DeleteLocation(int locationid);
        Location GetLocationByCity(string city);
        Location GetLocationByLocationid(int locationid);
        IEnumerable<Location> GetLocations();
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int userid);
        User GetUserByUsername(string username);
        User GetUserByUserid(int userid);
        IEnumerable<User> GetUsers();
        void AddOrder(Order order);
        void EditOrder(Order order);
        void DeleteOrder(int orderid);
        Order GetOrderByOcustomerid(int ocustomerid);
        Order GetOrderByOrderid(int orderid);
        IEnumerable<Order> GetOrders();
        void AddPizza(Pizza pizza);
        void EditPizza(Pizza pizza);
        void DeletePizza(int pizzaid);
        Pizza GetPizzaByPorderid(int porderid);
        Pizza GetPizzaByPizzaid(int pizzaid);
        IEnumerable<Pizza> GetPizzas();
        void AddTopping(Topping topping);
        void EditTopping(Topping topping);
        void DeleteTopping(int Toppingid);
        Topping GetToppingByTpizzaid(int tpizzaid);
        Topping GetToppingByToppingid(int toppingid);
        IEnumerable<Topping> GetToppings();
        void Save();
    }
}
