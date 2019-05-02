using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using PartyInvites.Services;

namespace PartyInvites.Controllers
{
    public class OrderController : Controller
    {

        CountService countService;

        public ViewResult Orders()
        {
            countService = new CountService();
        
            var vegetarians = countService.GetNumberOfPeopleVegetarian();
            var isGoingByBus = countService.GetNumberOfPeopleGoingByBus();

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
