using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
       
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email, password, status;
            email = txtEmail.Text;
            password = txtPassword.Text;
            Authentication check = new Authentication();
            status = check.Auth(email, password);
            if (status == "approved")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
            else if (status == "wpass")
            {
                MessageBox.Show("Wrong Password ! Please check your password again.");
            }
            else if (status == "wemail")
            {
                MessageBox.Show("Wrong Email ! Please check your email again.");
            }
        }
        private static void ThreadProc()
        {
            Application.Run(new Home());
        }
    }
}
