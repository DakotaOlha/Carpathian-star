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
        Form1 parentform;
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
        }

        private void Start_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            childAccForm.ShowDialog();
        }
    }
}
