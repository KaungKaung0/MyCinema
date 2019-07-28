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
    public partial class SelectMovie : Form
    {
        public static string selected_movie = "";
        public static string m1, m2, m3;
        string[] movie_receiver = new string[3];
        public SelectMovie()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Movie query = new Movie();
            movie_receiver = query.Show();
            m1 = movie_receiver[0];
            m2 = movie_receiver[1];
            m3 = movie_receiver[2];
            picMovOne.Image = Image.FromFile(@"D:\MyCinema\resource\poster\lionKing.jpg");
            picMovTwo.Image = Image.FromFile(@"D:\MyCinema\resource\poster\Mulan.jpg");
            picMovThree.Image = Image.FromFile(@"D:\MyCinema\resource\poster\onceuponatimeinhollywood.jpg");
        }

        private void PicMovOne_Click(object sender, EventArgs e)
        {
            selected_movie = m1;
            CloseAndOpen("time");
        }

        private void PicMovTwo_Click(object sender, EventArgs e)
        {
            selected_movie = m2;
            CloseAndOpen("time");
        }

        private void PicMovThree_Click(object sender, EventArgs e)
        {
            selected_movie = m3;
            CloseAndOpen("time");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            CloseAndOpen("dashboard");
        }

        private void CloseAndOpen(string form)
        {
            if(form == "time")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTime));
                t.Start();
                this.Close();
            }
           else if (form == "dashboard")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenDashboard));
                t.Start();
                this.Close();
            }
        }
        private static void OpenDashboard()
        {
            Application.Run(new Home());
        }
        private static void OpenTime()
        {
            Application.Run(new SelectTime());
        }
    }
}
