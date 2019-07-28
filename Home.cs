﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           OpenView("saleticket");
        }
        private void OpenView(string view)
        {
            if(view == "saleticket")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(SaleView));
                t.Start();
                this.Close();
            }
            else if(view == "moviedb")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(MovieDB));
                t.Start();
                this.Close();
            }
            
        }
        private static void MovieDB()
        {
            Application.Run(new ManageMovie());
        }
        private static void SaleView()
        {
            Application.Run(new SelectMovie());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenView("moviedb");
        }
    }
}
