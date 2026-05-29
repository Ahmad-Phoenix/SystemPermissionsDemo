using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsAdminManegar : clsAdmin
    {
        enum enMode { eAddNew = 1, eUpdate = 2 };
        enMode Mode = enMode.eUpdate;

        public clsAdminManegar()
        {

            this.AdminID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Age = 0;
            this.Permissions = 0;
            this.Username = "";
            this.Password = "";
            this.Email = "";
            this.PhoneNumber = "";
            this.IsActive = true;
            this.DateJoined = DateTime.Now;

            Mode = enMode.eAddNew;
        }

        private clsAdminManegar(int AdminID, string firstName, string lastName, byte age, string email, string phoneNumber, bool isActive,
                    string userName, string password, int Permissions, DateTime DateJoined)
        : base(AdminID, firstName, lastName, age, email, phoneNumber,
           isActive, userName, password, Permissions, DateJoined)
        {
            this.AdminID = AdminID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Username = userName;
            this.Password = password;
            this.Permissions = Permissions;
            this.PhoneNumber = phoneNumber;
            this.IsActive = true;
            this.DateJoined = DateJoined;

            Mode = enMode.eUpdate;
        }

        private bool _AddNewAdmin()
        {

            this.AdminID = DataAccessLayer.clsAdminDataAccess.AddNewAdmin(this.FirstName, this.LastName, this.Age, this.Email, this.PhoneNumber, this.IsActive,
            this.Username, this.Password, this.Permissions, this.DateJoined);

            return (this.AdminID != -1);
        }

        private bool _UpdateAdminToDataBase()
        {
            return DataAccessLayer.clsAdminDataAccess.UpdateAdmin(this.AdminID, this.FirstName, this.LastName, this.Age, this.Email, this.PhoneNumber, this.IsActive,
            this.Username, this.Password, this.Permissions, this.DateJoined);
        }

        public static clsAdminManegar GetAdminByUsernameAndPassword(string UserName, string Password)
        {
            string FirstName = "", LastName = "", Email = "", PhoneNumber = "";
            int AdminID = -1;
            byte Age = 0;
            int Permissions = 0;
            bool IsActive = false;
            DateTime DateJoined = default;

            if (clsAdminDataAccess.GetAdminByUsernameAndPassword(ref AdminID, ref FirstName, ref LastName, ref Age, ref Email, ref PhoneNumber, ref IsActive,
            ref UserName, ref Password, ref Permissions, ref DateJoined))
                return new clsAdminManegar(AdminID, FirstName, LastName, Age, Email, PhoneNumber, IsActive,
                     UserName, Password, Permissions, DateJoined);
            else
                return null;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.eAddNew:
                {
                    if (_AddNewAdmin())
                    {
                        Mode = enMode.eUpdate;
                        return true;
                    }
                    else
                        return false;
                }
                case enMode.eUpdate:
                    return _UpdateAdminToDataBase();
            }


            return false;
        }


        public static DataTable GetAllContacts()
        {
            return DataAccessLayer.clsAdminDataAccess.GetAllAdmins();
        }

        //public static bool isContactExist(int ID)
        //{
        //    //return clsContactDataAccess.IsContactExist(ID);
        //}

        //public static bool DeleteContact(int ID)
        //{
        //    return clsContactDataAccess.DeleteContact(ID);
        //}

        //public static bool isContactExist(int ID)
        //{
        //    return clsContactDataAccess.IsContactExist(ID);
        //}
    }
}
