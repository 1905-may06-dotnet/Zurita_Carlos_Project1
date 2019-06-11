using System;
using System.Collections.Generic;
using System.Text;
using PizzaBox.Domain;

namespace PizzaBox.Data
{
    public static class Mapper
    {
        public static Data.Entities.Location Map(Domain.Location dmLocation)
        {
            Data.Entities.Location deLocation = new Entities.Location();
            deLocation.Locationid = dmLocation.Locationid;
            deLocation.Street1 = dmLocation.Street1;
            deLocation.Street2 = dmLocation.Street2;
            deLocation.City = dmLocation.City;
            deLocation.State = dmLocation.State;
            deLocation.Country = dmLocation.Country;
            deLocation.Zipcode = dmLocation.Zipcode;

            return deLocation;
        }
        public static Domain.Location Map(Data.Entities.Location deLocation) => new Domain.Location
        {
            Locationid = deLocation.Locationid,
            Street1 = deLocation.Street1,
            Street2 = deLocation.Street2,
            City = deLocation.City,
            State = deLocation.State,
            Country = deLocation.Country,
            Zipcode = deLocation.Zipcode
        };

        public static Data.Entities.User Map(Domain.User dmUser)
        {
            Data.Entities.User deUser = new Entities.User();
            deUser.Userid = dmUser.Userid;
            deUser.Username = dmUser.Username;
            deUser.Password = dmUser.Password;
            deUser.Firstname = dmUser.Firstname;
            deUser.Lastname = dmUser.Lastname;
            deUser.Ulocationid = dmUser.Ulocationid;

            return deUser;
        }
        public static Domain.User Map(Data.Entities.User deUser) => new Domain.User
        {
            Userid = deUser.Userid,
            Username = deUser.Username,
            Password = deUser.Password,
            Firstname = deUser.Firstname,
            Lastname = deUser.Lastname,
            Ulocationid = deUser.Ulocationid
        };

        public static Data.Entities.Order Map(Domain.Order dmOrder)
        {
            Data.Entities.Order deOrder = new Entities.Order();
            deOrder.Orderid = dmOrder.Orderid;
            deOrder.Ocustomerid = dmOrder.Ocustomerid;
            deOrder.Datetime = dmOrder.Datetime;

            return deOrder;
        }
        public static Domain.Order Map(Data.Entities.Order deOrder) => new Domain.Order
        {
            Orderid = deOrder.Orderid,
            Ocustomerid = deOrder.Ocustomerid,
            Datetime = deOrder.Datetime
        };

        public static Data.Entities.Pizza Map(Domain.Pizza dmPizza)
        {
            Data.Entities.Pizza dePizza = new Entities.Pizza();
            dePizza.Pizzaid = dmPizza.Pizzaid;
            dePizza.Size = dmPizza.Size;
            dePizza.Crust = dmPizza.Crust;
            dePizza.Cost = dmPizza.Cost;
            dePizza.Porderid = dmPizza.Porderid;

            return dePizza;
        }
        public static Domain.Pizza Map(Data.Entities.Pizza dePizza) => new Domain.Pizza
        {
            Pizzaid = dePizza.Pizzaid,
            Size = dePizza.Size,
            Crust = dePizza.Crust,
            Cost = dePizza.Cost,
            Porderid = dePizza.Porderid

        };

        public static Data.Entities.Topping Map(Domain.Topping dmTopping)
        {
            Data.Entities.Topping deTopping = new Entities.Topping();
            deTopping.Toppingid = dmTopping.Toppingid;
            deTopping.Tpizzaid = dmTopping.Tpizzaid;
            deTopping.Topping1 = dmTopping.Topping1;

            return deTopping;
        }
        public static Domain.Topping Map(Data.Entities.Topping deTopping) => new Domain.Topping
        {
            Toppingid = deTopping.Toppingid,
            Tpizzaid = deTopping.Tpizzaid,
            Topping1 = deTopping.Topping1

        };
    }
}
