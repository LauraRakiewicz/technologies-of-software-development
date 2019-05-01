using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class OrderController : Controller
    {

        public ViewResult Orders()
        {
            var vegetarians = Repository.Responses.Where(r => r.GuestOrder.IsVegetarian == true).Count();
            var isGoingByBus = Repository.Responses.Where(r => r.GuestOrder.IsGoingByBus == true).Count();

            var mod = new OrderModel(vegetarians, isGoingByBus);
            return View(mod);
        }

    }
    public class OrderModel
    {
        public OrderModel(int vegetarians, int isGoingByBus)
        {
            this.Vegetarians = vegetarians;
            this.IsGoingByBus = isGoingByBus;
        }

        public int Vegetarians { get; set; }
        public int IsGoingByBus { get; set; }
           
    }

}
