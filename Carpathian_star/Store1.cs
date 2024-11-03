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
    public partial class Store1 : Form
    {
        StoreInfo baseForm;
        public Store1(StoreInfo form)
        {
            InitializeComponent();
            baseForm = form;
            baseForm.Hide();
            this.FormClosed += (s, args) => baseForm.form1.Show();

        }

        private void Store1_Load(object sender, EventArgs e)
        {
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
