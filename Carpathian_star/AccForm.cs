using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            //
            InitializeComponent();
            Program.ApplyCustomFont(this.Controls);

            Login_textBox.Focus();
            enterWindow = form;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.BorderColor = Color.White;
            Exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Exit.FlatAppearance.MouseOverBackColor = Color.Transparent;

            this.KeyPreview = true;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Login_textBox.Text != "" && Password_textBox.Text != "")
            {
                string login = Login_textBox.Text,
                    password = Password_textBox.Text,
                    filePath = System.IO.Path.Combine(Environment.CurrentDirectory, "Dani.json"),
                    line = $"{login}, {password}, 15000";
                if (password.Length < 4)
                {
                    MessageBox.Show("Пароль повинен мати не менше 4 знаків.");
                    return;
                }

                List<UserData> users = new List<UserData>();
                if (File.Exists(filePath))
                {
                    var jsonData = File.ReadAllText(filePath);
                    users = JsonSerializer.Deserialize<List<UserData>>(jsonData) ?? new List<UserData>();
                }

                var existingUser = users.FirstOrDefault(user => user.Login == login);

                if (existingUser != null)
                {
                    if (existingUser.Password == password)
                    {
                        enterWindow.parentform.login = existingUser.Login;
                        enterWindow.parentform.password = existingUser.Password;
                        enterWindow.parentform.Balance = existingUser.Balance;
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
                    // Если пользователь не найден, создаем нового
                    var newUser = new UserData
                    {
                        Login = login,
                        Password = password,
                        Balance = 15000
                    };
                    users.Add(newUser);

                    var updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, updatedJson);

                    enterWindow.parentform.login = login;
                    enterWindow.parentform.password = password;
                    enterWindow.parentform.Balance = 15000;
                    MessageBox.Show("Ви зареєструвалися успішно.");
                    Login_textBox.Clear();
                    Password_textBox.Clear();
                    enterWindow.Start.Enabled = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Введіть логін та пароль.");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Login_textBox.Focus();
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

        private void AccForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { 
                Exit_Click(sender, e);
            }
        }
    }
}
