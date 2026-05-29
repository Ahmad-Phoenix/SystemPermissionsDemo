using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BinaryDS
{
    public partial class frmLoginScreen : Form
    {
        private static readonly string filePath = "InfoRememberMe.txt";

        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private bool IsAdminExit(string UserName, string Password)
        {
            return (clsAdminManegar.GetAdminByUsernameAndPassword(UserName, Password) != null);
        }

        static void SaveLoginData(string filePath, string username, string password, bool rememberMeChecked = false)
        {
            try
            {
                string data = $"{username}#//#{password}#//#{rememberMeChecked}";
                File.WriteAllText(filePath, data);
            }
            catch (Exception ex)
            {
            }
        }

        static (string username, string password, bool RememberMeChecked) RetrieveLoginData(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string data = File.ReadAllText(filePath);

                    string[] parts = data.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    if (parts.Length == 3)
                    {
                        return (parts[0], parts[1], (bool)Convert.ToBoolean(parts[2]));
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return (null, null, false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string UserName = tbUserName.Text, Password = tbPassword.Text;


            if (IsAdminExit(UserName, Password))
            {
                if (cbRememberMe.Checked)
                {
                    SaveLoginData(filePath, tbUserName.Text, tbPassword.Text, cbRememberMe.Checked);
                }

                this.Hide();

                using (frmBinaryRepresentationPermissionsAppDemo frm = new frmBinaryRepresentationPermissionsAppDemo())
                {
                    frm.ShowDialog();
                }

                this.Show();

                tbPassword.Clear();
                tbUserName.Focus();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            try
            {
                string UserName, Password;
                bool RememberMeChecked = false;
                (UserName, Password, RememberMeChecked) = RetrieveLoginData(filePath);

                if (UserName != null && Password != null)
                {
                    tbUserName.Text = UserName;
                    tbPassword.Text = Password;
                    cbRememberMe.Checked = RememberMeChecked;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
