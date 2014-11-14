using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SbaSecurity;

namespace OCA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LogoForm());

            //SbaSecurity.Activation_Form Act_Frm = new SbaSecurity.Activation_Form();
            //Application.Run(Act_Frm);
            //if (Act_Frm.SA == true)
            //{

            Login:
                LoginForm LoginFrm = new LoginForm();
                Application.Run(LoginFrm);

                if (LoginFrm.Valid_User == true)
                {
                    MainForm MainFrm = new MainForm();
                    Application.Run(MainFrm);

                    if (MainFrm.Goto_Login == true)
                        goto Login;
                }

            //}
        }
    }
}