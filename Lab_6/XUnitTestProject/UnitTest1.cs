using PartyInvites.Models;
using PartyInvites.Services;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class CountServiceTest
    {
        private CountService countService;

        public CountServiceTest()
        {
            countService = new CountService();

            GuestOrder guestOrder = new GuestOrder()
            {
                IsGoingByBus = true,
                IsVegetarian = true
            };

            GuestResponse guestResponse1 = new GuestResponse()
            {
                Name = "Ala",
                WillAttend = true,
                GuestOrder = guestOrder 
            };

            Repository.AddResponse(guestResponse1);



            GuestOrder guestOrder2 = new GuestOrder()
            {
                IsGoingByBus = true,
                IsVegetarian = false
            };
            GuestResponse guestResponse2 = new GuestResponse()
            {
                Name = "Ala",
                WillAttend = true,
                GuestOrder = guestOrder2
            };

            Repository.AddResponse(guestResponse2);
         
        }

        [Fact]
        public void GetNumberOfPeopleGoingByBus_GetNumber_ReturnCorrectValue()
        {
            var countedValue = countService.GetNumberOfPeopleGoingByBus();
            Assert.Equal(2, countedValue);
        }

    }
}
