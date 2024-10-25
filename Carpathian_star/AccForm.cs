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
    public partial class AccForm : Form
    {
        EnterWindow enterWindow;
        public AccForm(EnterWindow form)
        {
            InitializeComponent();
            enterWindow = form;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            enterWindow.Start.Enabled = true;
            this.Close();
        }
    }
}
