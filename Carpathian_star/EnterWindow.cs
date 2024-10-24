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
        public EnterWindow()
        {
            InitializeComponent();
        }

        private void EnterWindow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
