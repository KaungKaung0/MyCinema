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
    public partial class Seat : Form
    {
        public static string selected_seat ="";
        public static int total_seat = 0;
        public static int total_price = 0;
        public static int seat_A_price, seat_B_price, seat_C_price;

        private void Seat_Load(object sender, EventArgs e)
        {
            MovieLabel.Text = SelectMovie.selected_movie;
            ShowTimeLabel.Text = Time.selected_time;
            ShowDateLabel.Text = Time.date;
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            btnA2.Enabled = false;
            selected_seat = selected_seat + btnA2.Text + ",";
            SelectedSeatLabel.Text = selected_seat;
            total_price = 2500 + total_price;
            TotalPriceLabel.Text = total_price + "Ks";
        }

        public Seat()
        {
            InitializeComponent();
        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            btnA1.Enabled = false;
            selected_seat = selected_seat + btnA1.Text +",";
            SelectedSeatLabel.Text = selected_seat;
            total_price = 2500 + total_price;
            TotalPriceLabel.Text = total_price + "Ks";
        }
    }
}
