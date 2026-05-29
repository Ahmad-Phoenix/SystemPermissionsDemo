using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsAdmin : clsPerson
    {

        public int AdminID { get; set; }
        public int Permissions { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateJoined { get; set; }

        public clsAdmin()
        {
            this.AdminID = -1;
            this.Username = "";
            this.FirstName = "";
            this.LastName = "";
            this.Age = 0;
            this.Permissions = 0;
            this.Password = "0000";
            this.Email = "";
            this.PhoneNumber = "";
            this.IsActive = false;
            this.DateJoined = DateTime.Now;
        }

        public clsAdmin(int AdminID, string firstName, string lastName, byte age, string email, string phoneNumber,
                    bool isActive, string userName, string Password, int Permissions, DateTime DateJoined)
        : base(firstName, lastName, age, email, phoneNumber)
        {
            this.Username = userName;
            this.Password = Password;
            this.Permissions = Permissions;
            this.IsActive = isActive;
            this.DateJoined = DateJoined;
        }
    }
}
