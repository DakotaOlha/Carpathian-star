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
            if (Login_textBox.Text != "" && Password_textBox.Text != "")
            {
                string login = Login_textBox.Text,
                    password = Password_textBox.Text,
                    filePath = @"d:\My files\3 course\Team Development\joint project 1\Carpathian_star\Dani.dot",
                    line = $"{login}, {password}, 500";
                var matchingLine = File.ReadLines(filePath).FirstOrDefault(line => line.StartsWith($"{login}"));

                if (matchingLine != null)
                {
                    var parts = matchingLine.Split(',').Select(part => part.Trim()).ToArray();
                    if (parts[1] == password)
                    {
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
    }
}
