﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpathian_star
{
    public partial class StoreInfo : Form
    {
        public Form1 form1;
        int numForm = 0;
        public StoreInfo(Form1 form, int i)
        {
            InitializeComponent();
            form1 = form;
            numForm = i;
            var screen = Screen.FromControl(this);
            this.Top = screen.Bounds.Height / 2 - this.Height / 2;
            this.Left = screen.Bounds.Width / 2 - this.Width / 2;
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            form1.Hide();
            switch (numForm)
            {
                case 1:
                    {
                        Store1 store1 = new Store1(this);
                        store1.FormClosed += (s, args) => form1.Show();
                        store1.Show();
                        break;
                    }
                default:
                    break;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
    }
}
