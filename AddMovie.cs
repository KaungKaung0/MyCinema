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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            picUserIcon.Image = Image.FromFile(@"D:\MyCinema\resource\placeholder\ph_addmovie.jpg");
        }

        private void PicUserIcon_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Movie addmovie = new Movie();
            string name = txtName.Text;
            string genre = txtGenre.Text;
            string theater = txtTheater.Text;
            string start = dtStart.Text;
            string end = dtEnd.Text;
            addmovie.Insert(name, genre, theater, start, end);
            CloseAndOpen();
        }
        //For Closing The Current Form and Opening new One
        private void CloseAndOpen()
        {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ManageMovie));
                t.Start();
                this.Close();
        }
        private static void ManageMovie()
        {
            Application.Run(new ManageMovie());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CloseAndOpen();
        }
    }
}
