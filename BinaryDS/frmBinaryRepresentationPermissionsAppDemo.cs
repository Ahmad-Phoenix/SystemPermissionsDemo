using BusinessLayer;
using GlobalUtilityLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static BinaryDS.clsPermissionsUsingBitwise;

namespace BinaryDS
{
    public partial class frmBinaryRepresentationPermissionsAppDemo : Form
    {

        List<bool> PermissionsStates;

        List<CheckBox> CheckBoxesPermissions;

        List<TextBox> PermissionsMap;

        string OriginalValue = string.Empty;

        public frmBinaryRepresentationPermissionsAppDemo()
        {
            InitializeComponent();

            clsGlobalUserSession.CurrentAdmin = new clsAdminManegar();
        }

        private void clb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    cbAddUser.Checked = true;
                    cbDeleteUser.Checked = true;
                    cbUpdateUser.Checked = true;
                    cbBlockUser.Checked = true;
                    cbShowUsersList.Checked = true;
                    cbSetUserWarning.Checked = true;
                    cbVerifyUser.Checked = true;
                    cbTotalUsersView.Checked = true;
                }
                else
                {
                    cbAddUser.Checked = false;
                    cbDeleteUser.Checked = false;
                    cbUpdateUser.Checked = false;
                    cbBlockUser.Checked = false;
                    cbShowUsersList.Checked = false;
                    cbSetUserWarning.Checked = false;
                    cbVerifyUser.Checked = false;
                    cbTotalUsersView.Checked = false;
                }
            }
        }

        private void LoadPermissionsToUI(int CurrentAdminPermissions)
        {
            var ReadPermissionsMapChecked = new Dictionary<System.Windows.Forms.CheckBox, clsPermissionsUsingBitwise.enMainPermissions>
            {
                { cbDeleteUser, clsPermissionsUsingBitwise.enMainPermissions.eDeleteUser },
                { cbAddUser, clsPermissionsUsingBitwise.enMainPermissions.eAddUser },
                { cbUpdateUser, clsPermissionsUsingBitwise.enMainPermissions.eUpdateUser },
                { cbBlockUser, clsPermissionsUsingBitwise.enMainPermissions.eBlockUser },
                { cbShowUsersList, clsPermissionsUsingBitwise.enMainPermissions.eShowUsersList },
                { cbSetUserWarning, clsPermissionsUsingBitwise.enMainPermissions.eSetUserWarning },
                { cbVerifyUser, clsPermissionsUsingBitwise.enMainPermissions.eVerifyUser },
                { cbTotalUsersView, clsPermissionsUsingBitwise.enMainPermissions.eTotalUsersView }
            };

            int i = 0;
            foreach (var item in ReadPermissionsMapChecked)
            {
                item.Key.Checked = clsPermissionsUsingBitwise.HasAccess(CurrentAdminPermissions, (int)item.Value);
                PermissionsStates[i] = item.Key.Checked;
                i++;
            }
        }

        private void UnselectAllItems()
        {
            clsUIHelpers.SelectAllItems(PermissionsStates, clb, false);
            clsPermissionsUsingBitwise.CalculateBinaryRepresentation(clsAppSettings.seDataRevealPath, (int)clsPermissionsUsingBitwise.enMainPermissions.eNone, PermissionsMap);
        }

        private void btnApplyPermissions_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalUtilityLayer.clsSounds.PlaySoundWav(clsAppSettings.seClickPath);

                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CountPermissionsStates();
                    clsGlobalUserSession.CurrentAdmin.Permissions = clsPermissionsUsingBitwise.CalculatePermissions(PermissionsStates);
                    if (clsGlobalUserSession.CurrentAdmin.Save())
                    {
                        CalculateBinaryRepresentation(clsAppSettings.seDataRevealPath, clsGlobalUserSession.CurrentAdmin.Permissions, PermissionsMap);

                        MessageBox.Show("Data has been saved successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: Could not save admin data.\n" + ex.Message,
                    "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!clsUIHelpers.ValidateTextBoxNotEmpty(tbUser, epMainMenu, "Missing Data", "Username is required!") ||
                !clsUIHelpers.ValidateTextBoxNotEmpty(tbPassword, epMainMenu, "Missing Data", "Password is required!"))
            {
                return;
            }

            try
            {
                clsGlobalUserSession.CurrentAdmin = clsAdminManegar.GetAdminByUsernameAndPassword(tbUser.Text, tbPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during authentication.\n" + ex.Message,
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobalUserSession.CurrentAdmin != null)
            {
                lbPermissionAccess.Text = "Permission Access Granted!";
                if (clsGlobalUserSession.CurrentAdmin.Permissions == (int)clsPermissionsUsingBitwise.enMainPermissions.eAll)
                {
                    clsUIHelpers.SelectAllItems(PermissionsStates, clb);
                }
                else if (clsGlobalUserSession.CurrentAdmin.Permissions == (int)clsPermissionsUsingBitwise.enMainPermissions.eNone)
                {
                    UnselectAllItems();
                }
                else
                {
                    LoadPermissionsToUI(clsGlobalUserSession.CurrentAdmin.Permissions);
                }
                clsPermissionsUsingBitwise.CalculateBinaryRepresentation(clsAppSettings.seDataRevealPath , clsGlobalUserSession.CurrentAdmin.Permissions, PermissionsMap);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UnselectAllItems();
        }

        private void ClickButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            System.Windows.Forms.CheckBox associatedCheckBox = (System.Windows.Forms.CheckBox)btn.Tag;

            if (associatedCheckBox != null)
            {
                if (!associatedCheckBox.Checked)
                {
                    MessageBox.Show($"Security Alert: You do not have the required credentials to access the {btn.Text} Section.",
                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show($"Authentication Verified: Full access to {btn.Text} Section has been granted.",
                        "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void MapButtonsToPermissions()
        {
            btnDeleteUser.Tag = cbDeleteUser;
            btnAddUser.Tag = cbAddUser;
            btnUpdateUser.Tag = cbUpdateUser;
            btnBlockUser.Tag = cbBlockUser;
            btnShowUsersList.Tag = cbShowUsersList;
            btnSetUserWarning.Tag = cbSetUserWarning;
            btnVerifyUser.Tag = cbVerifyUser;
            btnTotalUsersView.Tag = cbTotalUsersView;
        }

        private void SetupFormAppearance()
        {
            this.CenterToScreen();
            this.Size = new Size(920, 750);
        }

        private void SetupButtonIcons()
        {
            try
            {
                clsUIHelpers.BtnIconTxt(btnReset, clsAppSettings.iconLoginIconPath);
                clsUIHelpers.BtnIconTxt(btnCheckPermission, clsAppSettings.iconSettingsIconPath);
                clsUIHelpers.BtnIconTxt(btnApplyPermissions, clsAppSettings.iconApplyIconPath);
                clsUIHelpers.BtnIconTxt(btnLogin, clsAppSettings.iconResetIconPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading UI icons. Please ensure the 'Assist' folder exists.\n" + ex.Message,
                    "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CountPermissionsStates()
        {
            for (int i = 0; i < CheckBoxesPermissions.Count; i++)
            {
                PermissionsStates[i] = CheckBoxesPermissions[i].Checked;
            }
        }

        private void frmBinaryRepresentationPermissionsAppDemo_Load(object sender, EventArgs e)
        {
            PermissionsStates = new List<bool>
            {
                cbDeleteUser.Checked,
                cbAddUser.Checked,
                cbUpdateUser.Checked,
                cbBlockUser.Checked,
                cbShowUsersList.Checked,
                cbSetUserWarning.Checked,
                cbVerifyUser.Checked,
                cbTotalUsersView.Checked
            };

            CheckBoxesPermissions = new List<CheckBox>
            {
                cbDeleteUser,
                cbAddUser,
                cbUpdateUser,
                cbBlockUser,
                cbShowUsersList,
                cbSetUserWarning,
                cbVerifyUser,
                cbTotalUsersView
            };

            PermissionsMap = new List<TextBox>
            {
                tbDeleteBinary,
                tbAddUserBinary,
                tbUpdateBinary,
                tbBlockBinary,
                tbShowUserListBinary,
                tbSetUserWarningBinary,
                tbVerifyUserBinary,
                tbTotalUsersViewBinary
            };

            SetupFormAppearance();
            SetupButtonIcons();
            MapButtonsToPermissions();
        }
        private void MouseEnterBlue_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;

            OriginalValue = tb.Text;

            tb.Text = clsPermissionsUsingBitwise.GetMaskedBinaryToDecmial(tb.Text).ToString();

            GlobalUtilityLayer.clsSounds.PlaySoundWav(clsAppSettings.@seHoverPath);
            ((System.Windows.Forms.TextBox)sender).BackColor = Color.CornflowerBlue;
        }

        private void LeaveWhite_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;

            if (OriginalValue != string.Empty) tb.Text = OriginalValue;

            (tb).BackColor = this.BackColor;
        }

        private void btnCheckPermission_Click(object sender, EventArgs e)
        {
            GlobalUtilityLayer.clsSounds.PlaySoundWav(clsAppSettings.@seClickPath);
            CountPermissionsStates();
            clsGlobalUserSession.CurrentAdmin.Permissions = clsPermissionsUsingBitwise.CalculatePermissions(PermissionsStates);
            clsPermissionsUsingBitwise.CalculateBinaryRepresentation(clsAppSettings.seDataRevealPath, clsGlobalUserSession.CurrentAdmin.Permissions, PermissionsMap);
        }
    }
}