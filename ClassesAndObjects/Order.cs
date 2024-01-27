using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Order
    {

        int i;
        static int j;

        //private Order()
        //{

        //}

        ~Order()
        {

        }

        static Order()
        {
            j = 200;
        }


        public Order(int orderID)
        {
            OrderID = orderID;
        }

        public Order()
        {
            Status = "Placed";
            OrderID = 123;
        }
        public string Status { get; set; }

        public int OrderID { get; set; }


        public int GetStaticVariable()
        {
            return j;
        }

        //public Order GetOrderDetails()
        //{
        //    // DB Calls to retreve data from database

        //    return new Order(OrderID);
        //}
    }
}
