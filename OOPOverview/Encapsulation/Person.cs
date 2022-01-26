using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private int age;

        public void SetAge(int value)
        {
            if (value > 0)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentException("yaş değeri 0'ın altında olamaz");
            }
        }

        public int GetAge()
        {
            return age;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }

            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set { 
                lastName = value;
            }
        }


        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }





    }
}
