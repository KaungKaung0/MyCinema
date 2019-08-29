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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            picUserIcon.Image = Image.FromFile(@"D:\MyCinema\resource\placeholder\ph_user.jpg");

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Staff add = new Staff();
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtpass.Text;
            add.Insert(name, email, password);
            CloseAndOpen();
        }
        private void CloseAndOpen()
        {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ManageStaff));
                t.Start();
                this.Close();  
        }
        private static void ManageStaff()
        {
            Application.Run(new StaffManage());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CloseAndOpen();
        }
    }
}
