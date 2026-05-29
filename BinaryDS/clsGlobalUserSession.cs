using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDS
{
    public static class clsGlobalUserSession
    {
        public static BusinessLayer.clsAdminManegar CurrentAdmin { get; set; }

        public static bool IsUserLoggedIn => CurrentAdmin != null;
    }
}