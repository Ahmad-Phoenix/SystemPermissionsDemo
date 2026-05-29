using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

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

        static enMainPermissions[] enumsPermissionsMap =
        {
            enMainPermissions.eDeleteUser,
            enMainPermissions.eAddUser,
            enMainPermissions.eUpdateUser,
            enMainPermissions.eBlockUser,
            enMainPermissions.eShowUsersList,
            enMainPermissions.eSetUserWarning,
            enMainPermissions.eVerifyUser,
            enMainPermissions.eTotalUsersView
        };

        static public void PlayBinaryRevealAnimation(string @soundPath, System.Windows.Forms.TextBox tbBinary, string finalBin)
        {
            GlobalUtilityLayer.clsSounds.PlaySoundWav(@soundPath);
            char[] array = { '0', '1' };
            int tickCount = 0;

            Timer t = new Timer();

            t.Interval = 60;
            Random rand = new Random();

            t.Tick += (s, n) =>
            {
                char[] temp = new char[8];
                for (int i = 0; i < 8; i++)
                    temp[i] = array[rand.Next(0, 2)];

                tbBinary.Text = new string(temp);

                tickCount++;

                if (tickCount >= 15)
                {
                    GlobalUtilityLayer.clsSounds.StopSoundWav(@soundPath);
                    t.Stop();
                    tbBinary.Text = finalBin;
                    t.Dispose();
                }
            };

            t.Start();
        }

        public static void CalculateBinaryRepresentation(string @soundPath, int CurrentAdminPermissions, List<TextBox> PermissionsMap)
        {
            string eightBits = "00000000";

            for (int i = 0; i < enumsPermissionsMap.Length; i++)
            {
                if (HasAccess(CurrentAdminPermissions, (int)enumsPermissionsMap[i]))
                    PlayBinaryRevealAnimation(@soundPath, PermissionsMap[i], GetMaskedBinary(CurrentAdminPermissions, (int)enumsPermissionsMap[i]));
                else
                {
                    if (PermissionsMap[i].Text != eightBits)
                        PlayBinaryRevealAnimation(@soundPath, PermissionsMap[i], eightBits);
                }
            }
        }

        public static int CalculatePermissions(List<bool> permissionsStates)
        {
            if (permissionsStates == null || permissionsStates.Count < 8)
                return (int)enMainPermissions.eNone;

            if (permissionsStates.All(state => state))
                return (int)enMainPermissions.eAll;

            int totalPermissions = (int)enMainPermissions.eNone;

            for (int i = 0; i < permissionsStates.Count; i++)
            {
                if (permissionsStates[i])
                    totalPermissions += (int)enumsPermissionsMap[i];
            }

            return totalPermissions;
        }

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
            if (Permission == -1) return true;
            return (Permission & (int)MainMenuePermissions) == (int)MainMenuePermissions;
        }
    }
}