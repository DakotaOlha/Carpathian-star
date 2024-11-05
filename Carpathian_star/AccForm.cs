using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carpathian_star
{
    public partial class AccForm : Form
    {
        EnterWindow enterWindow;
        public AccForm(EnterWindow form)
        {
            InitializeComponent();
            Program.ApplyCustomFont(this.Controls);
            enterWindow = form;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.BorderColor = Color.White;
            Exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.CenterToScreen();

            Login_textBox.Focus();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Login_textBox.Text != "" && Password_textBox.Text != "")
            {
                string login = Login_textBox.Text,
                    password = Password_textBox.Text,
                    filePath = System.IO.Path.Combine(Environment.CurrentDirectory, "Dani.dot"),
                    line = $"{login}, {password}, 500";
                if (password.Length < 4) {
                    MessageBox.Show("Пароль повинен мати не менше 4 знаків.");
                    return;
                }
                var matchingLine = File.ReadLines(filePath).FirstOrDefault(line => line.StartsWith($"{login},"));

                if (matchingLine != null)
                {
                    var parts = Regex.Split(matchingLine, @"\s*, \s*");
                    if (parts[1] == password)
                    {
                        enterWindow.parentform.login = parts[0];
                        enterWindow.parentform.password = parts[1];
                        enterWindow.parentform.Balance = int.Parse(parts[2]);
                        MessageBox.Show("Ви увійшли успішно.");
                        Login_textBox.Clear();
                        Password_textBox.Clear();
                        enterWindow.Start.Enabled = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не вірний пароль");
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(line);
                    }
                    enterWindow.parentform.Balance = 500;
                    enterWindow.parentform.login = Login_textBox.Text;
                    enterWindow.parentform.password = Password_textBox.Text;
                    MessageBox.Show("Ви зареєструвалися успішно.");
                    Login_textBox.Clear();
                    Password_textBox.Clear();
                    enterWindow.Start.Enabled = true;
                    this.Close();
                }

            }
            else
                MessageBox.Show("Введіть логін та пароль.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password_textBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Password_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter_Click(sender, e);
            }
        }
    }
}
