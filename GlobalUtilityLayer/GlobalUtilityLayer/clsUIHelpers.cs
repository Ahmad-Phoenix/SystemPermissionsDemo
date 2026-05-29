using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GlobalUtilityLayer
{
    public class clsUIHelpers
    {
        public static bool ValidateTextBoxNotEmpty(
            Control c,
            ErrorProvider err,
            string caption,
            string message)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                err.SetError(c, message);

                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                c.Focus();
                return false;
            }

            err.SetError(c, "");
            return true;
        }

        public static void SetAllItemsChecked(CheckedListBox clb, bool select = true)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(i, select);
            }
        }

        public static void SetButtonIcon(Button btn, string iconPath)
        {
            if (File.Exists(iconPath))
            {
                btn.Image = Image.FromFile(iconPath);
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        public static void SelectAllItems(List<bool> permissionsStates, CheckedListBox clb, bool select = true)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(i, select);
                permissionsStates[i] = select;
            }
        }

        public static void BtnIconTxt(System.Windows.Forms.Button btn, string @IconPath)
        {
            btn.Image = System.Drawing.Image.FromFile(IconPath);
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
    }
}