using Microsoft.AspNetCore.Mvc;
using AspNetMVCInterviewAssignment.Models;


namespace Customer.Controllers 
{
    public class Customer : Controller
    {

        //GET: /customer/orders
        public IActionResult Orders()
        {
            CustomerViewModel cust = new CustomerViewModel
            {
               FirstName = "John",
               LastName = "Smith",
               CustomerNumber = 111111,
               Orders = new List<CustomerOrder> 
               {
                new CustomerOrder
                {
                   OrderId = 1,
                    OrderDate = DateTime.Now,
                    Description = "Part 1",
                    Total = 10 
                },
                new CustomerOrder
                {
                    OrderId = 2,
                    OrderDate = DateTime.Now,
                    Description = "Part 2",
                    Total = 20
                },
                    new CustomerOrder
                {
                    OrderId = 3,
                    OrderDate = DateTime.Now,
                    Description = "Part 3",
                    Total = 30
                }
               }
            };
            return View(cust);
        }
    }
}