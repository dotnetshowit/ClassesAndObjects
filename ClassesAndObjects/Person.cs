using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        public Person()
        {
            MySecret = "MyNewSecret";
        }
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string MySecret { get; set; }

        public string GetMySecretByExposedMethod()
        {
            return GetMySecret();
        }

        private string GetMySecret()
        {
            return MySecret;
        }

        public string GetMySecretByExposedMethod2()
        {
            return GetMySecret();
        }




    }
}
