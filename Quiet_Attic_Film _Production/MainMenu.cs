﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Film__Production
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client c1= new Client();
            c1.Show();
            this.Hide();
                
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Production pp= new Production();
            pp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Location lc= new Location();
            lc.Show();  
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Property pt= new Property();
            pt.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Staff sf= new Staff();
            sf.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //write a code to back button
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
