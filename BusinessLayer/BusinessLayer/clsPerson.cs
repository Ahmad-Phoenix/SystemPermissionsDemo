using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsPerson
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public clsPerson()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age = 0;
            this.Email = "";
        }
        public clsPerson(string firstName, string lastName, byte age, string email, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
        
    }
}
