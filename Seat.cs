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
        public static string movie_name, time, date;
        string[] seat_price = new string[3];
        public static string selected_seat ="";
        public static int total_seat = 0;
        public static int total_price = 0;
        public static int seat_A_price, seat_B_price, seat_C_price;

        private void Seat_Load(object sender, EventArgs e)
        {
            movie_name = SelectMovie.selected_movie;
            time = Time.selected_time;
            date = Time.date;
            Sale seat = new Sale();
            seat_price = seat.Seat_price();
            MovieLabel.Text = SelectMovie.selected_movie;
            ShowTimeLabel.Text = Time.selected_time;
            ShowDateLabel.Text = Time.date;
            ButtonCheck(panel2);
        }
        public static void ButtonCheck(Panel panel)
        {
            Sale sale = new Sale();
            string[] bought_seat = sale.Bought_seat_id(movie_name, time, date);
            for (int i = 0; i < bought_seat.Length; i++)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is Button temp)
                    {
                        if (temp.Enabled == true)
                        {
                            if (temp.Name == ("btn" + bought_seat[i]))
                            {
                                temp.Enabled = false;
                                temp.Text = "Sold";
                                panel.Update();
                            }
                        }
                        else if (temp.Enabled == false)
                        {
                            if (temp.Name == ("btn" + bought_seat[i]))
                            {
                                temp.Enabled = true;
                                temp.Text = bought_seat[i];
                            }
                        }

                    }
                }
            }
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            btnA2.Enabled = false;
            selected_seat = selected_seat + btnA2.Text + ",";
            SelectedSeatLabel.Text = selected_seat;
            total_price = 2500 + total_price;
            TotalPriceLabel.Text = total_price + "Ks";
            //Storing Temporary Record 
            Sale temp = new Sale();
            temp.Record(null, btnA1.Text, movie_name, time, date);
        }

        public Seat()
        {
            InitializeComponent();
        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            if(btnA1.Text == "Selected" || btnA1.Text == "Sold")
            {
                btnA1.Enabled = false;
            }
            else
            {
                btnA1.Text = "Selected";
            }
            selected_seat = selected_seat + btnA1.Text +",";
            SelectedSeatLabel.Text = selected_seat;
            total_price = 2500 + total_price;
            TotalPriceLabel.Text = total_price + "Ks";
            Sale temp = new Sale();
            temp.Record(null, btnA1.Text, movie_name, time, date);
        }
    }
}
