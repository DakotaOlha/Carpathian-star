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
            InitializeComponent();
            childForm = new EnterWindow(this);
            childForm.FormClosed += (s, args) => this.Show();
            this.Text = "";
            this.ShowIcon = false;
            var screen = Screen.FromControl(this);
            this.Top = screen.Bounds.Height / 2 - this.Height / 2;
            this.Left = screen.Bounds.Width / 2 - this.Width / 2;
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
            Store7.BackColor = Color.GreenYellow;
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
            StoreInfo storeInfo = new StoreInfo(this, 1);
            storeInfo.FormClosed += (s, args) => this.Show();
            storeInfo.ShowDialog();
        }
    }
}
