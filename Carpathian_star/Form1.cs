using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Carpathian_star
{
    public partial class Form1 : Form
    {
        public long Balance = 0;
        public string login, password;
        int count = 0;
        EnterWindow childForm;

        public Form1()
        {
            this.CenterToScreen();
            InitializeComponent();
            Program.ApplyCustomFont(this.Controls);
            childForm = new EnterWindow(this);
            childForm.FormClosed += (s, args) => this.Show();
            this.Text = "";
            this.ShowIcon = false;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (count == 0)
            {
                ++count;
                childForm.ShowDialog();
                this.Hide();
            }
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Store1.BackColor = Color.GreenYellow;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Store1.BackColor = Color.SeaGreen;
        }
        private void Store8_MouseEnter(object sender, EventArgs e)
        {
            Store8.BackColor = Color.GreenYellow;
        }
        private void Store8_MouseLeave(object sender, EventArgs e)
        {
            Store8.BackColor = Color.SeaGreen;
        }
        private void Store2_MouseEnter(object sender, EventArgs e)
        {

            Store2.BackColor = Color.GreenYellow;
        }
        private void Store2_MouseLeave(object sender, EventArgs e)
        {
            Store2.BackColor = Color.SeaGreen;
        }
        private void Store3_MouseEnter(object sender, EventArgs e)
        {
            Store3.BackColor = Color.GreenYellow;
        }
        private void Store3_MouseLeave(object sender, EventArgs e)
        {
            Store3.BackColor = Color.SeaGreen;
        }
        private void Store7_MouseEnter(object sender, EventArgs e)
        {
            Store7.BackColor = Color.Red;
        }
        private void Store7_MouseLeave(object sender, EventArgs e)
        {
            Store7.BackColor = Color.SeaGreen;
        }
        private void Store6_MouseEnter(object sender, EventArgs e)
        {
            Store6.BackColor = Color.GreenYellow;
        }
        private void Store6_MouseLeave(object sender, EventArgs e)
        {
            Store6.BackColor = Color.SeaGreen;
        }
        private void Store4_MouseEnter(object sender, EventArgs e)
        {
            Store4.BackColor = Color.GreenYellow;
        }
        private void Store4_MouseLeave(object sender, EventArgs e)
        {
            Store4.BackColor = Color.SeaGreen;
        }
        private void Store5_MouseEnter(object sender, EventArgs e)
        {
            Store5.BackColor = Color.GreenYellow;
        }
        private void Store5_MouseLeave(object sender, EventArgs e)
        {

            Store5.BackColor = Color.SeaGreen;
        }

        private void Store1_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 7);
            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        public void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Store4_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 1);
            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store8_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 2);
            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store5_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 3);
            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store2_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 4);
            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store3_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 5);
            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Store6_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(this, 6);
            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Exit_Click(sender, e);
            }
        }
    }
}
