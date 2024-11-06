using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Carpathian_star
{
    public partial class EnterWindow : Form
    {
        public Form1 parentform;
        AccForm childAccForm;
        public EnterWindow(Form1 parent)
        {
            InitializeComponent();
            Program.ApplyCustomFont(this.Controls);
            childAccForm = new AccForm(this);
            childAccForm.FormClosed += (s, args) => this.Show();
            parentform = parent;
            Exit.FlatAppearance.BorderSize = 0;
            Profile.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Exit.FlatAppearance.MouseOverBackColor = Color.Transparent;

            this.KeyPreview = true;
        }

        private void EnterWindow_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;

            this.CenterToScreen();
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

        private void Exit_Click(object sender, EventArgs e)
        {
            parentform.Exit_Click(sender, e);
        }

        private void EnterWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                Profile_Click_1(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape) { 
                Exit_Click(sender, e);
            }
        }
    }
}
