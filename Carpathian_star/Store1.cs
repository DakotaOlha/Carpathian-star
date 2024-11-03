using Microsoft.VisualBasic.Logging;
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

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void item1_MouseClick(object sender, MouseEventArgs e)
        {
            if (baseForm.form1.Balance >= Convert.ToInt64(Price1.Text))
            {
                baseForm.form1.Balance -= Convert.ToInt64(Price1.Text);
                textBox1.Text = baseForm.form1.Balance.ToString();
                string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, "Dani.dot");
                try
                {
                    var lines = File.ReadAllLines(filePath).ToList();

                    for (int i = 0; i < lines.Count; i++)
                    {
                        var parts = lines[i].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(part => part.Replace(",", ""))
                                            .ToArray();
                        if (parts.Length >= 3 && parts[0] == baseForm.form1.login)
                        {
                            parts[2] = baseForm.form1.Balance.ToString();
                            lines[i] = string.Join(" ", parts);
                            break;
                        }
                    }
                    File.WriteAllLines(filePath, lines);
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
    }
}
