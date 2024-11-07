using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpathian_star
{
    public partial class Store3 : Form
    {
        StoreInfo baseForm;
        public Store3(StoreInfo form)
        {
            InitializeComponent();
            Program.ApplyCustomFont(this.Controls);

            baseForm = form;
            baseForm.Hide();
            this.FormClosed += (s, args) => baseForm.form1.Show();
            this.ShowIcon = false;
            this.CenterToScreen();
        }


        private void CorectBalanse(Label label)
        {
            if (baseForm.form1.Balance >= Convert.ToInt64(label.Text))
            {
                baseForm.form1.Balance -= Convert.ToInt64(label.Text);
                BalanceLabel.Text = baseForm.form1.Balance.ToString();
                string filePath = Path.Combine(Environment.CurrentDirectory, "Dani.json");
                try
                {
                    var jsonData = File.ReadAllText(filePath);
                    var users = JsonSerializer.Deserialize<List<UserData>>(jsonData) ?? new List<UserData>();

                    var user = users.FirstOrDefault(u => u.Login == baseForm.form1.login);
                    if (user != null)
                    {
                        user.Balance = baseForm.form1.Balance;
                    }

                    var updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, updatedJson);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при оновленні файлу: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("У вас недостатньо коштів");
            }
        }


        private void Store3_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Item1_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price1);
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price2);
        }

        private void Item3_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price3);
        }

        private void Item4_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price4);
        }

        private void Item5_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price5);
        }

        private void Item6_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price6);
        }

        private void Item7_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price7);
        }

        private void Item8_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price8);
        }

        private void Item9_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price9);
        }

        private void Item10_Click(object sender, EventArgs e)
        {
            CorectBalanse(Price10);
        }
    }
}
