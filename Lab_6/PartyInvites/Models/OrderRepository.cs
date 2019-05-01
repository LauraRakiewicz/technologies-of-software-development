using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class OrderRepository
    {
        private static List<GuestOrder> responses = new List<GuestOrder>();

        public static IEnumerable<GuestOrder> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(GuestOrder guestOrder)
        {
            responses.Add(guestOrder);
        }
    }
}
