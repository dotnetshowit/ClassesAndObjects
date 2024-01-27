using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Order myOrder = new Order();

            //Order myOrder2 = new Order(123);
            //Console.WriteLine(myOrder.GetStaticVariable());
            //Console.WriteLine(myOrder.GetStaticVariable());

            //myOrder.GetOrderDetails();

            //Order myOrder3 = new Order(456);
            //Console.WriteLine(myOrder3.GetStaticVariable());


            //Console.WriteLine(myOrder.Status);
            //Console.WriteLine(myOrder2.OrderID);



            // Abstraction
            // Encapsulation
            // Inheritance


            // Access Specifiers

            // public
            // private
            // protected
            // internal
            // protected internal


            Person person1 = new Person();
            Console.WriteLine(person1.GetMySecretByExposedMethod());

            Console.ReadLine();
        }
    }
}
