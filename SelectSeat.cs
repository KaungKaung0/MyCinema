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
    public partial class SelectSeat : Form
    {
        string[] seat_price = new string[4];
        public static string selected_seat ="";
        public static int total_seat = 0;
        public static int total_price = 0;
        public static int seat_A_price, seat_B_price, seat_C_price,seat_D_price;
        public static string selected_movie, selected_time, selected_date;

        public SelectSeat()
        {
            InitializeComponent();
        }
        private void Seat_Load(object sender, EventArgs e)
        {
            Get_Seat_Price();
            selected_movie = SelectMovie.selected_movie;
            selected_time = SelectTime.selected_time;
            selected_date = SelectTime.date;
            MovieLabel.Text = selected_movie;
            ShowTimeLabel.Text = selected_time;
            ShowDateLabel.Text = selected_date;
            ButtonCheck(panel2);
        }
        private void Get_Seat_Price()
        {
            Sale seat = new Sale();
            seat_price = seat.Seat_price();
            seat_A_price = int.Parse(seat_price[0]);
            seat_B_price = int.Parse(seat_price[1]);
            seat_C_price = int.Parse(seat_price[2]);
            seat_D_price = int.Parse(seat_price[3]);
            //Show Seat Price Label
            lblSeatA.Text = seat_A_price.ToString();
            lblSeatB.Text = seat_B_price.ToString();
            lblSeatC.Text = seat_C_price.ToString();
            lblSeatD.Text = seat_D_price.ToString();
        }
        //Check Button Sold or Not
        public static void ButtonCheck(Panel panel)
        {
            Sale sale = new Sale();
            string[] bought_seat = sale.Bought_seat_id(selected_movie,selected_time,selected_date);
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

        private void BtnbkTime_Click(object sender, EventArgs e)
        {
            Seat_Clear();
            CloseAndOpen("time");
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            btnA2.Enabled = false;
            selected_seat += btnA2.Text + ",";
            SelectedSeatLabel.Text = selected_seat;
            total_price += seat_A_price;
            total_seat += 1;
            TotalPriceLabel.Text = total_price.ToString() + "Ks";
            Sale temp = new Sale();
            temp.Record(null, btnA2.Text, selected_movie, selected_time, selected_date);
        }

        private void BtnSold_Click(object sender, EventArgs e)
        {
            Sale voucher = new Sale();
            voucher.CreateVoucher(selected_date,selected_movie,selected_time,selected_seat,total_seat,total_price);
            MessageBox.Show("Thanks! Have a great time");
            Seat_Clear();
            CloseAndOpen("sold");
        }

        private void CloseAndOpen(string form)
        {
            if (form == "time")
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
            else if (form == "sold")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMovie));
                t.Start();
                this.Close();
            }

        }
        private static void OpenMovie()
        {
            Application.Run(new SelectMovie());
        }
        //Open CLose form Control
        private static void OpenDashboard()
        {
            Application.Run(new Home());
        }
        private static void OpenTime()
        {
            Application.Run(new SelectTime());
        }

        private void BtnA1_Click_1(object sender, EventArgs e)
        {
            btnA1.Enabled = false;
            selected_seat += btnA1.Text + ",";
            SelectedSeatLabel.Text = selected_seat;
            total_price += seat_A_price;
            total_seat += 1;
            TotalPriceLabel.Text = total_price.ToString() + "Ks";
            Sale temp = new Sale();
            temp.Record(null, btnA1.Text, selected_movie, selected_time, selected_date);

        }
        private void BtnClearChoice_Click(object sender, EventArgs e)
        {
            Sale clear = new Sale();
            clear.Clear(selected_movie, selected_time, selected_date);
            Seat_Clear();
        }
        private void Seat_Clear()
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is Button temp)
                {
                    if (temp.Enabled == false && temp.Text != "Sold")
                    {
                        temp.Enabled = true;
                    }
                }
            }
            SelectedSeatLabel.Text = "Not Selected";
            TotalPriceLabel.Text = "0Ks";
            total_price = 0;
            total_seat = 0;
            selected_seat = "";
        }
    }
}
