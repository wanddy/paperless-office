using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OCA.Business;
using OCA.WinUI;

namespace OCA
{
    public partial class LoginForm : Divelements.SandRibbon.RibbonForm
    {
        OCA.Business.Public pubclass = new Public();
        private static Boolean ValidUser;
        int LoginFailed;
        
        public Boolean Valid_User
        {
            get 
            {
                return ValidUser;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ValidUser = false;
            LoginFailed = 1;
        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) txt_Password.Focus();
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) BtnLogin.PerformClick();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (pubclass.IsUserValid(txt_Username.Text.Trim(), txt_Password.Text.Trim()))
                {
                    ValidUser = true;

                    MainForm mfrm = new MainForm();
                    mfrm.Online_Username = txt_Username.Text.Trim();

                    Close();
                }
            }
            catch (Exception ex)
            {
                OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
                mesg.Error("خطا", ex.Message);

                if (LoginFailed == 3) this.Close();

                LoginFailed++;
                txt_Username.Clear();
                txt_Password.Clear();
                txt_Username.Focus();
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            txt_Username.Text = pubclass.SqlInjection(txt_Username.Text);
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.Text = pubclass.SqlInjection(txt_Password.Text);
        }

    }
}