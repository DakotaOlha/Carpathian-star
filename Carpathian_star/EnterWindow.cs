using System;
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
    public partial class EnterWindow : Form
    {
        public Form1 parentform;
        AccForm childAccForm;
        public EnterWindow(Form1 parent)
        {
            InitializeComponent();
            childAccForm = new AccForm(this);
            childAccForm.FormClosed += (s, args) => this.Show();
            parentform = parent;
        }

        private void EnterWindow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            pictureBox1.BorderStyle = BorderStyle.None;
        }


        private void Profile_Click_1(object sender, EventArgs e)
        {
            childAccForm.ShowDialog();
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }
    }
}
