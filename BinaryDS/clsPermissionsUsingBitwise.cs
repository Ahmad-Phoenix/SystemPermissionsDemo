using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDS
{
    public static class clsPermissionsUsingBitwise
    {

        [Flags]
        public enum enMainPermissions : int
        {
            eAll = -1,
            eNone = 0,

            eDeleteUser = 1,
            eAddUser = 2,
            eUpdateUser = 4,
            eBlockUser = 8,
            eShowUsersList = 16,
            eSetUserWarning = 32,
            eVerifyUser = 64,
            eTotalUsersView = 128
        };

        public static string GetMaskedBinary(int permission, int mask, int bitsLong = 8)
        {
            const int base2 = 2;
            return Convert.ToString((permission & mask), base2).PadLeft(bitsLong, '0');
        }

        public static int GetMaskedBinaryToDecmial(string BinaryPermission)
        {
            const int base2 = 2;
            return Convert.ToInt32(BinaryPermission, base2);
        }

        public static bool HasAccess(int Permission, int MainMenuePermissions)
        {
            if (Permission == -1)
                return true;

            if ((Permission & (int)MainMenuePermissions) == (int)MainMenuePermissions)
                return true;

            return false;
        }


    }
}