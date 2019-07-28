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
    public partial class SelectTime : Form
    {
        public static string selected_time, date;
        public SelectTime()
        {
            InitializeComponent();
        }

        private void BackToMovieSelect_Click(object sender, EventArgs e)
        {
            CloseAndOpen("Movie");
        }
       
        private void Time_Load(object sender, EventArgs e)
        {
            MovieLabel.Text = SelectMovie.selected_movie;
            ShowDateLabel.Text = dateTimePicker1.Text;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowDateLabel.Text = dateTimePicker1.Text;
        }

        private void FirstTime_Click(object sender, EventArgs e)
        {
            selected_time = FirstTime.Text;
            date = dateTimePicker1.Text;
            CloseAndOpen("Seat");
        }

        private void SecondTime_Click(object sender, EventArgs e)
        {
            selected_time = SecondTime.Text;
            date = dateTimePicker1.Text;
            CloseAndOpen("Seat");
        }

        private void ThirdTime_Click(object sender, EventArgs e)
        {
            selected_time = ThirdTime.Text;
            date = dateTimePicker1.Text;
            CloseAndOpen("Seat");
        }

        //For Closing The Current Form and Opening new One
        private void CloseAndOpen(string view)
        {
            if (view == "Movie")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(MovieView));
                t.Start();
                this.Close();
            }
            else if (view == "Seat")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(SeatView));
                t.Start();
                this.Close();
            }
        }
        private static void SeatView()
        {
            Application.Run(new SelectSeat());
        }
        private static void MovieView()
        {
            Application.Run(new SelectMovie());
        }

    }
}
