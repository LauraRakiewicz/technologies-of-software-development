using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartyInvites.Models;

namespace PartyInvites.Services
{
    public class CountService
    {

        public int GetNumberOfPeopleGoingByBus()
        {
            return Repository.Responses.Where(r => r.GuestOrder.IsGoingByBus).Count();
        }

        public int GetNumberOfPeopleVegetarian()
        {
            return Repository.Responses.Where(r => r.GuestOrder.IsVegetarian).Count();
        }
        
    }
}
