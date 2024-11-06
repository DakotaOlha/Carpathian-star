using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Carpathian_star
{
    public partial class StoreInfo : Form
    {
        public Form1 form1;
        int numForm = 0;
        public StoreInfo(Form1 form, int i)
        {
            InitializeComponent();
            Program.ApplyCustomFont(this.Controls);
            form1 = form;
            numForm = i;
            this.CenterToScreen();
        }

        public void SetLabelText(string text, string text1, string text2, string text3)
        {
            OwnerLabel.Text = text; 
            ProductLabel.Text = text1;
            WorkHoursLabel.Text = text2;
            ReputationLabel.Text = text3;
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
                        store1.BalanceLabel.Text = form1.Balance.ToString();
                        store1.Show();
                        break;
                    }
                case 2:
                    {
                        Store2 store2 = new Store2(this);
                        store2.FormClosed += (s, args) => form1.Show();
                        store2.BalanceLabel.Text = form1.Balance.ToString();
                        store2.Show();
                        break;
                    }
                case 3:
                    {
                        Store3 store3 = new Store3(this);
                        store3.FormClosed += (s, args) => form1.Show();
                        store3.BalanceLabel.Text = form1.Balance.ToString();
                        store3.Show();
                        break;
                    }
                case 4:
                    {
                        Store4 store4 = new Store4(this);
                        store4.FormClosed += (s, args) => form1.Show();
                        store4.BalanceLabel.Text = form1.Balance.ToString();
                        store4.Show();
                        break;
                    }
                case 5:
                    {
                        Store5 store5 = new Store5(this);
                        store5.FormClosed += (s, args) => form1.Show();
                        store5.BalanceLabel.Text = form1.Balance.ToString();
                        store5.Show();
                        break;
                    }
                case 6:
                    {
                        Store6 store6 = new Store6(this);
                        store6.FormClosed += (s, args) => form1.Show();
                        store6.BalanceLabel.Text = form1.Balance.ToString();
                        store6.Show();
                        break;
                    }
                case 7:
                    {
                        FortuneTeller teller = new FortuneTeller(this);
                        teller.FormClosed += (s, args) => form1.Show();
                        teller.BalanceLabel.Text = form1.Balance.ToString();
                        teller.Show();
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

        private void StoreInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
